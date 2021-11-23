using System.Collections.Generic;

namespace Jgs.EventSourcing.Messages
{
    public class Metadata : ValueObject
    {
        #region Creation

        public Metadata(CommandId traceId, UserId userId)
        {
            TraceId = traceId;
            UserId = userId;
        }

        #endregion

        #region Public Interface

        public CommandId TraceId { get; }
        public UserId UserId { get; }

        #endregion

        #region Equality

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return TraceId;
            yield return UserId;
        }

        #endregion
    }
}
