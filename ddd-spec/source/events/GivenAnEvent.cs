using FluentAssertions;
using Xunit;

namespace Jgs.Ddd.Spec
{
    public abstract class GivenAnEvent
    {
        #region Core

        private readonly Event _event;

        protected GivenAnEvent(Event @event)
        {
            _event = @event;
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenInstantiated_ThenIsAlwaysValid()
        {
            var expectedEventName = _event.GetType().Name;

            _event.Id.Should().NotBeEmpty();
            _event.Type.Should().Be(expectedEventName);
        }

        #endregion
    }
}
