using System;
using System.Linq;
using FluentAssertions;
using Jgs.Ddd;
using Xunit;

namespace Jgs.Cqrs.Spec.MessageStoreSpec
{
    public abstract class GivenAStore
    {
        #region Core

        private readonly FooCreated _fooCreated = new();
        private readonly IMessageStore _messageStore;
        private readonly StreamId _streamId;

        protected GivenAStore(IMessageStore messageStore)
        {
            _messageStore = messageStore;
            _streamId = new StreamId("foo", _fooCreated.FooId);
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenAnEventIsPublished_ThenTheEventIsStored()
        {
            var fooCreated = new FooCreated();

            _messageStore.Publish(_streamId, fooCreated);
            var events = _messageStore.Read(_streamId).ToList();

            events.Should().HaveCount(1);
            events.Should().Contain(fooCreated);
        }

        #endregion

        private record FooCreated : Event
        {
            #region Creation

            public FooCreated()
            {
                FooId = Guid.NewGuid();
            }

            #endregion

            #region Public Interface

            public Guid FooId { get; }

            #endregion
        }
    }
}
