using System;

namespace Jgs.EventSourcing
{
    public abstract class Id : TinyType<Guid>
    {
        #region Creation

        protected Id(Guid value = default) : base(
            value == Guid.Empty
                ? Guid.NewGuid()
                : value
        )
        {
        }

        #endregion
    }
}
