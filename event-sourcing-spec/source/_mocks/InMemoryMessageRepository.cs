using System;
using System.Collections.Generic;
using System.Linq;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Stores;
using Jgs.EventSourcing.Streams;

namespace Jgs.EventSourcing.Spec
{
    public class InMemoryMessageRepository : IMessageRepository
    {
        private readonly List<Message> _messages = new();

        #region Private Interface

        private IEnumerable<Message> Fetch(Func<Message, bool> predicate) => _messages.Where(predicate);

        #endregion

        #region IMessageRepository Implementation

        public bool Exists(Id messageId) => _messages.Exists(x => x.Id == messageId);
        public bool Exists(StreamId streamId) => _messages.Any(x => x.Storage.StreamId == streamId);
        public IEnumerable<Message> Fetch(StreamId streamId) => Fetch(x => x.Storage.StreamId == streamId);
        public Message Find(Id messageId) => _messages.Single(x => x.Id == messageId);
        public GlobalVersion GetGlobalVersion() => _messages.Last().Storage.GlobalVersion;
        public StreamVersion GetStreamVersion(StreamId streamId) => Fetch(streamId).Last().Storage.StreamVersion;

        public IMessageRepository Save(Message message)
        {
            _messages.Add(message);
            return this;
        }

        #endregion
    }
}
