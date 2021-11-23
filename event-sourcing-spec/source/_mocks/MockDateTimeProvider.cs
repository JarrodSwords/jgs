using System;
using Jgs.EventSourcing.Stores;

namespace Jgs.EventSourcing.Spec
{
    internal class MockDateTimeProvider : IDateTimeProvider
    {
        #region IDateTimeProvider Implementation

        public DateTime GetUtcNow() => ObjectProvider.UtcNow;

        #endregion
    }
}
