namespace Jgs.EventSourcing.Messages
{
    public class MessageType : TinyType<string>
    {
        #region Creation

        public MessageType(string value) : base(value)
        {
        }

        #endregion

        #region Static Interface

        public static implicit operator MessageType(string source) => new(source);

        #endregion
    }
}
