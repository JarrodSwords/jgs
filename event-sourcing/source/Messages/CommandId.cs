using System;

namespace Jgs.EventSourcing.Messages
{
    public class CommandId : Id
    {
        #region Creation

        public CommandId(Guid value = default) : base(value)
        {
        }

        #endregion

        #region Static Interface

        public static implicit operator CommandId(Guid source) => new(source);

        #endregion
    }
}
