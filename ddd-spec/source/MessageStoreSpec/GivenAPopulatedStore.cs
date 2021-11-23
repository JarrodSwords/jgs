using Xunit;

namespace Jgs.Ddd.Spec.MessageStoreSpec
{
    public abstract class GivenAPopulatedStore
    {
        #region Core

        private readonly IMessageStore _messageStore;

        protected GivenAPopulatedStore(IMessageStore messageStore)
        {
            _messageStore = messageStore;
        }

        #endregion

        #region Test Methods

        [Fact]
        public void WhenAMessageIsPublished_ThenSetItsStreamPosition()
        {
        }

        #endregion
    }
}
