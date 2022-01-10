using FluentAssertions;
using Xunit;

namespace Jgs.Functional.Spec.Explicit
{
    public class WhenCreatingASuccess
    {
        #region Test Methods

        [Fact]
        public void ThenResultIsSuccess()
        {
            var result = Functional.Explicit.Result<Error>.Success();

            result.IsFailure.Should().BeFalse();
            result.IsSuccess.Should().BeTrue();
        }

        #endregion
    }
}
