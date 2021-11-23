namespace Jgs.EventSourcing.Streams
{
    public class Category : TinyType<string>
    {
        #region Creation

        public Category(string value) : base(value)
        {
        }

        #endregion

        #region Public Interface

        public override string ToString() => Value;

        #endregion

        #region Static Interface

        public static implicit operator Category(string source) => new(source);

        #endregion
    }
}
