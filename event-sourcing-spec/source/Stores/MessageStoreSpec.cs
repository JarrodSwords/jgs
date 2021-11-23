using Jgs.EventSourcing.Stores;

namespace Jgs.EventSourcing.Spec.Stores
{
    public class MessageStoreSpec : IMessageStoreSpec
    {
        #region Creation

        public MessageStoreSpec() : base(Create())
        {
        }

        #endregion

        #region Static Interface

        private static IMessageStore Create() =>
            new MessageStore(
                ObjectProvider.DateTimeProvider,
                ObjectProvider.MessageRepository
            );

        #endregion

        public class GivenAStreamSpec : GivenAStream
        {
            #region Creation

            public GivenAStreamSpec() : base(Create())
            {
            }

            #endregion
        }

        public class GivenMultipleStreamsSpec : GivenMultipleStreams
        {
            #region Creation

            public GivenMultipleStreamsSpec() : base(Create())
            {
            }

            #endregion
        }
    }
}
