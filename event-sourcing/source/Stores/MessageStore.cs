using System;
using System.Collections.Generic;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Streams;

namespace Jgs.EventSourcing.Stores
{
    public class MessageStore : IMessageStore
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IMessageRepository _messageRepository;

        #region Creation

        public MessageStore(
            IDateTimeProvider dateTimeProvider,
            IMessageRepository messageRepository
        )
        {
            _dateTimeProvider = dateTimeProvider;
            _messageRepository = messageRepository;
        }

        #endregion

        #region Private Interface

        private MessageStore SaveImplementation(
            StreamId streamId,
            Message message,
            StreamVersion expectedVersion
        )
        {
            if (_messageRepository.Exists(message.Id))
                throw new InvalidOperationException();

            var globalVersion = _messageRepository.Exists(streamId)
                ? _messageRepository.GetGlobalVersion()
                : GlobalVersion.Default;

            var streamVersion = _messageRepository.Exists(streamId)
                ? _messageRepository.GetStreamVersion(streamId)
                : StreamVersion.Default;

            if (streamVersion != expectedVersion)
                throw new InvalidOperationException();

            var storage = new Storage(
                globalVersion.Next(),
                streamId,
                streamVersion.Next(),
                _dateTimeProvider.GetUtcNow()
            );

            message.Set(storage);

            _messageRepository.Save(message);

            return this;
        }

        #endregion

        #region IMessageStore Implementation

        public GlobalVersion GetGlobalVersion() => _messageRepository.GetGlobalVersion();
        public StreamVersion GetStreamVersion(StreamId streamId) => _messageRepository.GetStreamVersion(streamId);
        public IEnumerable<Message> Read(StreamId streamId) => _messageRepository.Fetch(streamId);

        public IMessageStore Save(
            AggregateStreamId streamId,
            Event @event,
            StreamVersion expectedVersion = default
        ) =>
            SaveImplementation(
                streamId,
                @event,
                expectedVersion ?? StreamVersion.Default
            );

        public IMessageStore Save(
            CommandStreamId streamId,
            Command command,
            StreamVersion expectedVersion = default
        ) =>
            SaveImplementation(
                streamId,
                command,
                expectedVersion ?? StreamVersion.Default
            );

        #endregion
    }
}
