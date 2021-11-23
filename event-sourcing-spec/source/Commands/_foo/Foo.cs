using Jgs.EventSourcing.Messages;

namespace Jgs.EventSourcing.Spec.Commands
{
    public class Foo : Command
    {
        #region Creation

        public Foo(
            UserId userId,
            CommandId traceId = default
        ) : base(
            userId,
            traceId
        )
        {
        }

        #endregion
    }
}
