namespace Jgs.EventSourcing.Streams
{
    public class StreamName : TinyType<string>
    {
        #region Creation

        public StreamName(string value) : base(value)
        {
        }

        #endregion
    }
}
