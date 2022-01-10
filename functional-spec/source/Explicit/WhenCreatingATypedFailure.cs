using FluentAssertions;
using Xunit;

namespace Jgs.Functional.Spec.Explicit
{
    public class WhenCreatingATypedFailure
    {
        #region Test Methods

        [Fact]
        public void ThenValueIsDefault()
        {
            var result = Functional.Explicit.Result<Error>.Failure<object>(Error.Foo);

            result.Value.Should().BeNull();
        }

        #endregion
    }
}
