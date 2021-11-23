using System.Linq;
using FluentAssertions;
using Xunit;

namespace Jgs.Ddd.Spec.MessageStoreSpec
{
    public abstract class GivenAnUnknownStream
    {
        #region Core

        private readonly IMessageStore _messageStore;
        private readonly StreamId _streamId = new("foo");

        protected GivenAnUnknownStream(IMessageStore messageStore)
        {
            _messageStore = messageStore;
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenRead_ThenEmptyStreamReturned()
        {
            var events = _messageStore.Read(_streamId).ToList();

            events.Should().NotBeNull();
            events.Should().BeEmpty();
        }

        #endregion
    }
}
