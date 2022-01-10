using FluentAssertions;
using Jgs.Functional.Explicit;
using Xunit;

namespace Jgs.Functional.Spec.Explicit
{
    public class WhenCreatingATypedSuccess
    {
        #region Test Methods

        [Fact]
        public void FromValue_ThenResultIsReturned()
        {
            Result<string, Error> result = "foo";

            result.Should().NotBeNull();
        }

        [Fact]
        public void ThenValueIsSet()
        {
            var result = Functional.Explicit.Result<Error>.Success("foo");

            result.Value.Should().Be("foo");
        }

        #endregion
    }
}
