using Jgs.EventSourcing.Messages;

namespace Jgs.EventSourcing.Spec.ValueObjects
{
    public class MessageTypeSpec
    {
        private const string Fooed = "Fooed";

        public class GivenDifferentValuesSpec : GivenDifferentValues
        {
            #region Creation

            public GivenDifferentValuesSpec() : base(
                new MessageType(Fooed),
                new MessageType("Barred")
            )
            {
            }

            #endregion
        }

        public class GivenSameReferenceSpec : GivenSameReference
        {
            #region Creation

            public GivenSameReferenceSpec() : base(new MessageType("Fooed"))
            {
            }

            #endregion
        }

        public class GivenSameValuesSpec : GivenSameValues
        {
            #region Creation

            public GivenSameValuesSpec() : base(
                new MessageType(Fooed),
                new MessageType(Fooed)
            )
            {
            }

            #endregion
        }
    }
}
