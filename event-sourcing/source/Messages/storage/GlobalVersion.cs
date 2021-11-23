namespace Jgs.EventSourcing.Messages
{
    public class GlobalVersion : TinyType<uint>
    {
        public static GlobalVersion Default = new(uint.MinValue);

        #region Creation

        public GlobalVersion(uint value) : base(value)
        {
        }

        #endregion

        #region Public Interface

        public GlobalVersion Next() => new(this + 1);

        #endregion

        #region Static Interface

        public static implicit operator GlobalVersion(uint source) => new(source);

        #endregion
    }
}
