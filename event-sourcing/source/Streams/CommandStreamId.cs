namespace Jgs.EventSourcing.Streams
{
    public class CommandStreamId : StreamId
    {
        #region Creation

        public CommandStreamId(
            Category category,
            Id aggregateId
        ) : base(
            category,
            new StreamName($"{category}:command-{aggregateId}")
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
