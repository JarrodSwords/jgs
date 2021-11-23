using System;

namespace Jgs.EventSourcing.Messages
{
    public class EventId : Id
    {
        #region Creation

        public EventId(Guid value = default) : base(value)
        {
        }

        #endregion

        #region Static Interface

        public static implicit operator EventId(Guid source) => new(source);

        #endregion
    }
}
