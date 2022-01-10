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
        }

        #endregion
    }
}
