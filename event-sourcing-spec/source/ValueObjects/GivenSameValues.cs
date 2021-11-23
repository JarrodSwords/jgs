using FluentAssertions;
using Xunit;

namespace Jgs.EventSourcing.Spec.ValueObjects
{
    public abstract class GivenSameValues
    {
        #region Core

        private readonly ValueObject _instance1;
        private readonly ValueObject _instance2;

        protected GivenSameValues(
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
        public void WhenEqualityChecked_ThenObjectsAreEqual()
        {
            _instance2.Should().NotBeSameAs(_instance1);
            _instance2.Should().Be(_instance1);
        }

        #endregion
    }
}
