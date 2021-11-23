﻿using Jgs.Ddd;
using Xunit;

namespace Jgs.Cqrs.Spec.MessageStoreSpec
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
