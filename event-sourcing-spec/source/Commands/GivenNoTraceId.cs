using FluentAssertions;
using Jgs.EventSourcing.Messages;
using Xunit;

namespace Jgs.EventSourcing.Spec.Commands
{
    public abstract class GivenNoTraceId
    {
        #region Core

        private readonly Command _command;

        protected GivenNoTraceId(Command command)
        {
            _command = command;
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenInstantiated_ThenMetadataDoesNotContainTraceId()
        {
            _command.Metadata.TraceId.Should().BeNull();
        }

        #endregion
    }
}
