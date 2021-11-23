using System.Collections.Generic;
using System.Diagnostics;

namespace Jgs.EventSourcing.Streams
{
    [DebuggerDisplay("{StreamName}")]
    public abstract class StreamId : ValueObject
    {
        #region Creation

        protected StreamId(
            Category category,
            StreamName streamName
        )
        {
            Category = category;
            StreamName = streamName;
        }

        #endregion

        #region Public Interface

        public Category Category { get; }
        public StreamName StreamName { get; }

        #endregion

        #region Equality

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Category;
        }

        #endregion
    }
}
