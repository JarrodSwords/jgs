using System;
using System.Collections.Generic;
using Jgs.EventSourcing.Streams;

namespace Jgs.EventSourcing.Messages
{
    public class Storage : ValueObject
    {
        #region Creation

        public Storage(
            GlobalVersion globalVersion,
            StreamId streamId,
            StreamVersion streamVersion,
            DateTime timestamp
        )
        {
            GlobalVersion = globalVersion ?? throw new ArgumentNullException();
            StreamId = streamId ?? throw new ArgumentNullException();
            StreamVersion = streamVersion ?? throw new ArgumentNullException();
            Timestamp = timestamp;
        }

        #endregion

        #region Public Interface

        public GlobalVersion GlobalVersion { get; }
        public StreamId StreamId { get; }
        public StreamVersion StreamVersion { get; }
        public DateTime Timestamp { get; }

        #endregion

        #region Equality

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return GlobalVersion;
            yield return StreamId;
            yield return StreamVersion;
            yield return Timestamp;
        }

        #endregion
    }
}
