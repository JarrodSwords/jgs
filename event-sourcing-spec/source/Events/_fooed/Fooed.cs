using Jgs.EventSourcing.Messages;

namespace Jgs.EventSourcing.Spec.Events
{
    public class Fooed : Event
    {
        #region Creation

        public Fooed(
            CommandId traceId,
            UserId userId
        ) : base(
            traceId,
            userId
        )
        {
        }

        #endregion
    }
}
