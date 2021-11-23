using System;
using FluentAssertions;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Spec.Events;
using Jgs.EventSourcing.Stores;
using Jgs.EventSourcing.Streams;
using Xunit;

namespace Jgs.EventSourcing.Spec.Stores
{
    public abstract class GivenAStream
    {
        #region Core

        private readonly Event _fooed = new Fooed(new CommandId(), new UserId());
        private readonly IMessageStore _messageStore;
        private readonly AggregateStreamId _streamId = new("bars", new BarId());

        protected GivenAStream(IMessageStore messageStore)
        {
            _messageStore = messageStore;

            _messageStore.Save(_streamId, _fooed);
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenADuplicateMessageIsSaved_ThenInvalidOperationExceptionThrown()
        {
            Action saveMessage = () => _messageStore.Save(_streamId, _fooed);

            saveMessage.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void WhenAMessageIsSaved_ThenTheStreamVersionIsIncremented()
        {
            var originalStreamVersion = _messageStore.GetStreamVersion(_streamId);
            var fooed = new Fooed(new CommandId(), new UserId());

            var updatedStreamVersion = _messageStore
                .Save(_streamId, fooed, 1)
                .GetStreamVersion(_streamId);

            updatedStreamVersion.Should().Be(++originalStreamVersion);
        }

        [Fact]
        public void WhenAMessageIsSaved_WithAnIncorrectVersion_ThenInvalidOperationExceptionThrown()
        {
            var targetVersion = _messageStore.GetStreamVersion(_streamId);
            _messageStore.Save(_streamId, ObjectProvider.CreateEvent(), 1);

            Action saveMessage = () => _messageStore.Save(_streamId, ObjectProvider.CreateEvent(), targetVersion);

            saveMessage.Should().Throw<InvalidOperationException>();
        }

        #endregion
    }
}
