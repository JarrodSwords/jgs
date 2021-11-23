using System.Linq;
using FluentAssertions;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Stores;
using Jgs.EventSourcing.Streams;
using Xunit;

namespace Jgs.EventSourcing.Spec.Stores
{
    public abstract class IMessageStoreSpec
    {
        #region Core

        private readonly Event _message = ObjectProvider.CreateEvent();
        private readonly IMessageStore _messageStore;
        private readonly AggregateStreamId _streamId = new("bars", new BarId());

        protected IMessageStoreSpec(IMessageStore messageStore)
        {
            _messageStore = messageStore;
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenAMessageIsSaved_ThenItIsRetrievable()
        {
            var storedMessages = _messageStore
                .Save(_streamId, _message)
                .Read(_streamId);

            storedMessages.Should().Contain(_message);
        }

        [Fact]
        public void WhenAMessageIsSaved_ThenItsStorageIsSet()
        {
            var storedMessage = _messageStore
                .Save(_streamId, _message)
                .Read(_streamId)
                .Single(x => x.Storage.StreamId == _streamId);

            storedMessage.Storage.Should().NotBeNull();
        }

        #endregion
    }
}
