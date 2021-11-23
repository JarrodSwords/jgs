using System;
using Jgs.EventSourcing.Streams;

namespace Jgs.EventSourcing.Messages
{
    public abstract class Event : Message
    {
        #region Creation

        protected Event(
            CommandId traceId,
            UserId userId,
            Storage storage = default
        ) : base(
            new EventId(),
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
            if (storage.StreamId.GetType() != typeof(AggregateStreamId))
                throw new InvalidOperationException();

            Storage = storage;

            return this;
        }

        #endregion
    }
}
