using FluentAssertions;
using Xunit;

namespace Jgs.Functional.Spec.Results
{
    public class GivenASuccess
    {
        #region Core

        private readonly Result _result = Result.Success();

        #endregion

        #region Test Methods

        [Fact]
        public void WhenBound_WithFunc_ThenResultIsFuncResult()
        {
            var funcResult = Result.Success();

            var result = _result.Bind(() => funcResult);

            result.Should().Be(funcResult);
        }

        #endregion
    }
}
