using FluentAssertions;
using Jgs.Functional.Explicit;
using Xunit;
using static Jgs.Functional.Explicit.Result<Jgs.Functional.Spec.Explicit.Error>;

namespace Jgs.Functional.Spec.Explicit
{
    public class WhenCreatingATypedFailure
    {
        #region Test Methods

        [Fact]
        public void FromError_ThenResultIsReturned()
        {
            Result<object, Error> result = Error.Foo;

            result.Value.Should().BeNull();
        }

        [Fact]
        public void ThenValueIsDefault()
        {
            var result = Failure<object>(Error.Foo);

            result.Value.Should().BeNull();
        }

        #endregion
    }
}
