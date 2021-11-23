using System;
using Jgs.EventSourcing.Streams;

namespace Jgs.EventSourcing.Messages
{
    public abstract class Command : Message
    {
        #region Creation

        protected Command(
            UserId userId,
            CommandId traceId = default,
            Storage storage = default
        ) : base(
            new CommandId(),
            traceId,
            userId,
            storage
        )
        {
        }

        #endregion

        #region Protected Internal Interface

        protected internal override Message Set(Storage storage)
        {
            if (storage.StreamId.GetType() != typeof(CommandStreamId))
                throw new InvalidOperationException();

            Storage = storage;

            return this;
        }

        #endregion
    }
}
