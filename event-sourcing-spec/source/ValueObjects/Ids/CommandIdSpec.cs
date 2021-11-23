using System;
using Jgs.EventSourcing.Messages;

namespace Jgs.EventSourcing.Spec.ValueObjects.Ids
{
    public class CommandIdSpec
    {
        public class GivenDifferentValuesSpec : GivenDifferentValues
        {
            #region Creation

            public GivenDifferentValuesSpec() : base(
                new CommandId(),
                new CommandId()
            )
            {
            }

            #endregion
        }

        public class GivenSameReferenceSpec : GivenSameReference
        {
            #region Creation

            public GivenSameReferenceSpec() : base(new CommandId())
            {
            }

            #endregion
        }

        public class GivenSameValuesSpec : GivenSameValues
        {
            private static readonly Guid Value = Guid.NewGuid();

            #region Creation

            public GivenSameValuesSpec() : base(
                new CommandId(Value),
                new CommandId(Value)
            )
            {
            }

            #endregion
        }
    }
}
