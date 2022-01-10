using FluentAssertions;
using Xunit;

namespace Jgs.Functional.Spec
{
    public class GivenAFailure
    {
        #region Core

        private readonly Result _result = Result.Failure("failed");

        #endregion

        #region Test Methods

        [Fact]
        public void WhenBound_WithFunc_ThenResultIsFailure()
        {
            var funcResult = Result.Success();

            var result = _result.Bind(() => funcResult);

            result.Should().Be(_result);
        }

        #endregion
    }
}
