namespace Jgs.EventSourcing.Messages
{
    public class StreamVersion : TinyType<uint>
    {
        public static StreamVersion Default = new(uint.MinValue);

        #region Creation

        public StreamVersion(uint value) : base(value)
        {
        }

        #endregion

        #region Public Interface

        public StreamVersion Next() => new(this + 1);

        #endregion

        #region Static Interface

        public static implicit operator StreamVersion(uint source) => new(source);

        #endregion
    }
}
