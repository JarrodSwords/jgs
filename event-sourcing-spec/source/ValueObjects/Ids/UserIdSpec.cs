using System;

namespace Jgs.EventSourcing.Spec.ValueObjects.Ids
{
    public class UserIdSpec
    {
        public class GivenDifferentValuesSpec : GivenDifferentValues
        {
            #region Creation

            public GivenDifferentValuesSpec() : base(
                new UserId(),
                new UserId()
            )
            {
            }

            #endregion
        }

        public class GivenSameReferenceSpec : GivenSameReference
        {
            #region Creation

            public GivenSameReferenceSpec() : base(new UserId())
            {
            }

            #endregion
        }

        public class GivenSameValuesSpec : GivenSameValues
        {
            private static readonly Guid Value = Guid.NewGuid();

            #region Creation

            public GivenSameValuesSpec() : base(
                new UserId(Value),
                new UserId(Value)
            )
            {
            }

            #endregion
        }
    }
}
