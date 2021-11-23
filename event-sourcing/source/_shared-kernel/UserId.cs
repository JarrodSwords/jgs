using System;

namespace Jgs.EventSourcing
{
    public class UserId : Id
    {
        #region Creation

        public UserId(Guid value = default) : base(value)
        {
        }

        #endregion

        #region Static Interface

        public static implicit operator UserId(Guid source) => new(source);

        #endregion
    }
}
