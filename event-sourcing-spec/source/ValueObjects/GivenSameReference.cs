using FluentAssertions;
using Xunit;

namespace Jgs.EventSourcing.Spec.ValueObjects
{
    public abstract class GivenSameReference
    {
        #region Core

        private readonly ValueObject _instance1;

        protected GivenSameReference(ValueObject instance1)
        {
            _instance1 = instance1;
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenEqualityChecked_ThenObjectsAreEqual()
        {
            var instance2 = _instance1;

            instance2.Should().BeSameAs(_instance1);
            instance2.Should().Be(_instance1);
        }

        #endregion
    }
}
