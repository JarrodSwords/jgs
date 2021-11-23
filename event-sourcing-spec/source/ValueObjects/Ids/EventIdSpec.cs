using System;
using Jgs.EventSourcing.Messages;

namespace Jgs.EventSourcing.Spec.ValueObjects.Ids
{
    public class EventIdSpec
    {
        public class GivenDifferentValuesSpec : GivenDifferentValues
        {
            #region Creation

            public GivenDifferentValuesSpec() : base(
                new EventId(),
                new EventId()
            )
            {
            }

            #endregion
        }

        public class GivenSameReferenceSpec : GivenSameReference
        {
            #region Creation

            public GivenSameReferenceSpec() : base(new EventId())
            {
            }

            #endregion
        }

        public class GivenSameValuesSpec : GivenSameValues
        {
            private static readonly Guid Value = Guid.NewGuid();

            #region Creation

            public GivenSameValuesSpec() : base(
                new EventId(Value),
                new EventId(Value)
            )
            {
            }

            #endregion
        }
    }
}
