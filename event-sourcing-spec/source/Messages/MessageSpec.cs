using FluentAssertions;
using Jgs.EventSourcing.Messages;
using Xunit;

namespace Jgs.EventSourcing.Spec.Messages
{
    public abstract class MessageSpec
    {
        #region Core

        private readonly Message _message;

        protected MessageSpec(Message message)
        {
            _message = message;
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenInstantiated_ThenIdIsNotEmpty()
        {
            _message.Id.Should().NotBeNull();
        }

        [Fact]
        public void WhenInstantiated_ThenTypeIsMessageTypeName()
        {
            var expected = new MessageType(_message.GetType().Name);
            _message.MessageType.Should().Be(expected);
        }

        #endregion
    }
}
