namespace Jgs.EventSourcing.Streams
{
    public class AggregateStreamId : StreamId
    {
        #region Creation

        public AggregateStreamId(
            Category category,
            Id aggregateId
        ) : base(
            category,
            new StreamName($"{category}-{aggregateId}")
        )
        {
            AggregateId = aggregateId;
        }

        #endregion

        #region Public Interface

        public Id AggregateId { get; }

        #endregion
    }
}
