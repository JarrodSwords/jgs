using FluentAssertions;
using Jgs.EventSourcing.Messages;
using Xunit;

namespace Jgs.EventSourcing.Spec.Messages
{
    public abstract class GivenMetadata
    {
        #region Core

        private readonly Message _message;
        private readonly CommandId _traceId = new();
        private readonly UserId _userId = new();

        protected GivenMetadata()
        {
            _message = Create(_traceId, _userId);
        }

        #endregion

        #region Protected Interface

        protected abstract Message Create(CommandId traceId, UserId userId);

        #endregion

        #region Test Methods

        [Fact]
        public void WhenInstantiated_ThenMetadataContainsTraceId()
        {
            _message.Metadata.TraceId.Should().Be(_traceId);
        }

        [Fact]
        public void WhenInstantiated_ThenMetadataContainsUserId()
        {
            _message.Metadata.UserId.Should().Be(_userId);
        }

        #endregion
    }
}
