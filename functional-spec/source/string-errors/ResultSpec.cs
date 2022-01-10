using FluentAssertions;
using Xunit;

namespace Jgs.Functional.Spec
{
    public class ResultSpec
    {
        #region Test Methods

        [Fact]
        public void WhenInstantiated_WithMessage_ThenOperationFailed()
        {
            const string message = "Failure";
            var result = Result.Failure(message);

            result.IsFailure.Should().BeTrue();
            result.IsSuccess.Should().BeFalse();
            result.Message.Should().Be(message);
        }

        [Fact]
        public void WhenInstantiated_WithoutMessage_ThenOperationWasSuccessful()
        {
            var result = Result.Success();

            result.IsFailure.Should().BeFalse();
            result.IsSuccess.Should().BeTrue();
            result.Message.Should().BeNull();
        }

        [Fact]
        public void WhenInstantiated_WithoutValue_ThenMessageIsSet()
        {
            const string message = "failed";
            var result = Result.Failure<object>(message);

            result.Value.Should().BeNull();
            result.Message.Should().Be(message);
            result.IsFailure.Should().BeTrue();
        }

        [Fact]
        public void WhenInstantiated_WithValue_ThenValueWasSet()
        {
            const int value = 1;
            var result = Result.Success(value);

            result.IsFailure.Should().BeFalse();
            result.IsSuccess.Should().BeTrue();
            result.Message.Should().BeNull();
            result.Value.Should().Be(value);
        }

        [Fact]
        public void WhenResultsAreCombined_WithNoFailures_ThenSuccessReturned()
        {
            var combinedResult = Result.Combine(Result.Success(), Result.Success());

            combinedResult.IsFailure.Should().BeFalse();
        }

        [Fact]
        public void WhenResultsAreCombined_WithSomeFailures_ThenFirstFailureReturned()
        {
            var combinedResult = Result.Combine(
                Result.Success(),
                Result.Failure("first"),
                Result.Failure("second")
            );

            combinedResult.IsFailure.Should().BeTrue();
            combinedResult.Message.Should().Be("first");
        }

        #endregion
    }
}
