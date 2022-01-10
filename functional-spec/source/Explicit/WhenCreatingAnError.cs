using FluentAssertions;
using Xunit;

namespace Jgs.Functional.Spec.Explicit
{
    public class WhenCreatingAnError
    {
        #region Test Methods

        [Fact]
        public void ThenResultIsFailure()
        {
            var result = Functional.Explicit.Result.Error();

            result.IsFailure.Should().BeTrue();
            result.IsSuccess.Should().BeFalse();
        }

        #endregion
    }

    public class WhenCreatingASuccess
    {
        #region Test Methods

        [Fact]
        public void ThenResultIsSuccess()
        {
            var result = Functional.Explicit.Result.Success();

            result.IsFailure.Should().BeFalse();
            result.IsSuccess.Should().BeTrue();
        }

        #endregion
    }
}
