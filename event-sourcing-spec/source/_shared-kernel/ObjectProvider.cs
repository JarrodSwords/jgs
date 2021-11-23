using System;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Spec.Commands;
using Jgs.EventSourcing.Spec.Events;
using Jgs.EventSourcing.Stores;

namespace Jgs.EventSourcing.Spec
{
    internal class ObjectProvider
    {
        #region Public Interface

        public static IDateTimeProvider DateTimeProvider => new MockDateTimeProvider();
        public static IMessageRepository MessageRepository => new InMemoryMessageRepository();
        public static UserId UserId { get; } = new();
        public static DateTime UtcNow { get; } = DateTime.UtcNow;

        #endregion

        #region Static Interface

        public static Command CreateCommand() => new Foo(UserId);
        public static Event CreateEvent() => new Fooed(new CommandId(), UserId);

        #endregion
    }
}
