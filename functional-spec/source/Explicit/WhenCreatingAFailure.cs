using FluentAssertions;
using Xunit;
using static Jgs.Functional.Explicit.Result<Jgs.Functional.Spec.Explicit.Error>;

namespace Jgs.Functional.Spec.Explicit
{
    public class WhenCreatingATypedFailure
    {
        #region Test Methods

        [Fact]
        public void ThenValueIsDefault()
        {
            var result = Failure<object>(Error.Foo);

            result.Value.Should().BeNull();
        }

        #endregion
    }

    public class WhenCreatingAFailure
    {
        #region Test Methods

        [Fact]
        public void FromError_ThenResultIsReturned()
        {
            Functional.Explicit.Result<Error> result = Error.Foo;

            result.Should().NotBeNull();
        }

        [Fact]
        public void ThenResultIsFailure()
        {
            var result = Failure(Error.Foo);

            result.IsFailure.Should().BeTrue();
            result.IsSuccess.Should().BeFalse();
        }

        [Fact]
        public void WithExplicitError_ThenReturnsError()
        {
            var result = Failure(Error.Foo);

            result.Error.Should().Be(Error.Foo);
        }

        #endregion
    }
}
