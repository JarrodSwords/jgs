using FluentAssertions;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Spec.Events;
using Jgs.EventSourcing.Stores;
using Jgs.EventSourcing.Streams;
using Xunit;

namespace Jgs.EventSourcing.Spec.Stores
{
    public abstract class GivenMultipleStreams
    {
        #region Core

        private readonly IMessageStore _messageStore;
        private readonly AggregateStreamId _stream1 = new("bars", new BarId());
        private readonly AggregateStreamId _stream2 = new("bazzes", new BazId());

        protected GivenMultipleStreams(IMessageStore messageStore)
        {
            _messageStore = messageStore;

            _messageStore.Save(_stream1, new Fooed(new CommandId(), new UserId()));
            _messageStore.Save(_stream2, new Fooed(new CommandId(), new UserId()));
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenAMessageIsSaved_ThenTheGlobalVersionIsIncremented()
        {
            var originalGlobalVersion = _messageStore.GetGlobalVersion();
            var fooed = new Fooed(new CommandId(), new UserId());

            var updatedGlobalVersion = _messageStore
                .Save(_stream1, fooed, 1)
                .GetGlobalVersion();

            updatedGlobalVersion.Should().Be(++originalGlobalVersion);
        }

        #endregion
    }
}
