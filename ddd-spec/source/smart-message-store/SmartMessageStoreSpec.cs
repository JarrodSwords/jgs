using Jgs.Ddd.Spec.MessageStoreSpec;

namespace Jgs.Ddd.Spec
{
    public static class SmartMessageStoreSpec
    {
        public class GivenAnUnknownStreamSpec : GivenAnUnknownStream
        {
            #region Creation

            public GivenAnUnknownStreamSpec() : base(new SmartMessageStore())
            {
            }

            #endregion
        }

        public class GivenAPopulatedStoreSpec : GivenAPopulatedStore
        {
            #region Creation

            public GivenAPopulatedStoreSpec() : base(new SmartMessageStore())
            {
            }

            #endregion
        }

        public class GivenAStoreSpec : GivenAStore
        {
            #region Creation

            public GivenAStoreSpec() : base(new SmartMessageStore())
            {
            }

            #endregion
        }
    }
}
