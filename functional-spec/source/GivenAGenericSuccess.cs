using FluentAssertions;
using Xunit;

namespace Jgs.Functional.Spec
{
    public class GivenAGenericSuccess
    {
        #region Core

        private readonly Result<int> _result = Result.Success(2);

        #endregion

        #region Test Methods

        [Fact]
        public void WhenBound_WithFuncWithInput_ThenResultIsFuncResult()
        {
            var result = _result.Bind(x => Result.Success(x * 3));

            result.Value.Should().Be(6);
        }

        #endregion
    }
}
