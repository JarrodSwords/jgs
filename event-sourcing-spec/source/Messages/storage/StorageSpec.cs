using System;
using FluentAssertions;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Streams;
using Xunit;

namespace Jgs.EventSourcing.Spec.Messages
{
    public class StorageSpec
    {
        #region Test Methods

        [Fact]
        public void WhenInstantiated_WithNullGlobalPosition_ThenArgumentNullExceptionThrown()
        {
            Action create = () => new Storage(
                null,
                new AggregateStreamId("foos", new BarId()),
                1,
                DateTime.UtcNow
            );

            create.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WhenInstantiated_WithNullStreamId_ThenArgumentNullExceptionThrown()
        {
            Action create = () => new Storage(
                1,
                null,
                1,
                DateTime.UtcNow
            );

            create.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WhenInstantiated_WithNullStreamPosition_ThenArgumentNullExceptionThrown()
        {
            Action create = () => new Storage(
                1,
                new AggregateStreamId("foos", new BarId()),
                null,
                DateTime.UtcNow
            );

            create.Should().Throw<ArgumentNullException>();
        }

        #endregion
    }
}
