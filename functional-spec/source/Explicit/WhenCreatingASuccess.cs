using FluentAssertions;
using Xunit;
using static Jgs.Functional.Explicit.Result<Jgs.Functional.Spec.Explicit.Error>;

namespace Jgs.Functional.Spec.Explicit
{
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
