namespace Jgs.EventSourcing.Streams
{
    public class CategoryStreamId : StreamId
    {
        #region Creation

        public CategoryStreamId(Category category) : base(
            category,
            new StreamName(category)
        )
        {
        }

        #endregion
    }
}
