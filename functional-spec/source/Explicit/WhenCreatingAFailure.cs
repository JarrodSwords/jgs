using FluentAssertions;
using Xunit;
using static Jgs.Functional.Explicit.Result<Jgs.Functional.Spec.Explicit.Error>;

namespace Jgs.Functional.Spec.Explicit
{
    public record Error(string Code, string Message)
    {
        public static Error Foo = new("foo", "this is not the success you're looking for");
    }

    public class WhenCreatingAFailure
    {
        #region Test Methods

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

    public class WhenCreatingASuccess
    {
        #region Test Methods

        [Fact]
        public void ThenResultIsSuccess()
        {
            var result = Success();

            result.IsFailure.Should().BeFalse();
            result.IsSuccess.Should().BeTrue();
        }

        #endregion
    }
}
