using FluentAssertions;
using Xunit;

namespace Jgs.EventSourcing.Spec.ValueObjects
{
    public abstract class GivenDifferentValues
    {
        #region Core

        private readonly ValueObject _instance1;
        private readonly ValueObject _instance2;

        protected GivenDifferentValues(
            ValueObject instance1,
            ValueObject instance2
        )
        {
            _instance1 = instance1;
            _instance2 = instance2;
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenEqualityChecked_ThenObjectsAreNotEqual()
        {
            _instance2.Should().NotBe(_instance1);
        }

        #endregion
    }
}
