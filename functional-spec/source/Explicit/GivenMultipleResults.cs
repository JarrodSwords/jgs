using FluentAssertions;
using Xunit;
using static Jgs.Functional.Explicit.Result<Jgs.Functional.Spec.Explicit.Error>;

namespace Jgs.Functional.Spec.Explicit
{
    public class GivenMultipleResults
    {
        #region Test Methods

        [Fact]
        public void WhenResultsAreCombined_WithNoFailures_ThenSuccessReturned()
        {
            var result = Combine(
                Success(),
                Success()
            );

            result.IsSuccess.Should().BeTrue();
        }

        [Fact]
        public void WhenResultsAreCombined_WithSomeFailures_ThenFirstFailureReturned()
        {
            var result = Combine(
                Success(),
                Failure(Error.Foo),
                Failure(Error.Bar)
            );

            result.IsFailure.Should().BeTrue();
            result.Error.Should().Be(Error.Foo);
        }

        #endregion
    }
}
