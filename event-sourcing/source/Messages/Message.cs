namespace Jgs.EventSourcing.Messages
{
    public abstract class Message
    {
        #region Creation

        protected Message(
            Id id,
            CommandId traceId,
            UserId userId,
            Storage storage
        )
        {
            Id = id;
            MessageType = GetType().Name;
            Metadata = new Metadata(traceId, userId);
            Storage = storage;
        }

        protected Message(
            Message prototype,
            Storage storage
        ) : this(
            prototype.Id,
            prototype.Metadata.TraceId,
            prototype.Metadata.UserId,
            storage
        )
        {
        }

        #endregion

        #region Public Interface

        public Id Id { get; }
        public MessageType MessageType { get; }
        public Metadata Metadata { get; }
        public Storage Storage { get; protected set; }

        #endregion

        #region Protected Internal Interface

        protected internal abstract Message Set(Storage storage);

        #endregion

        #region Equality

        public override bool Equals(object other)
        {
            if (other is null || GetType() != other.GetType())
                return false;

            return Id == ((Message) other).Id;
        }

        #endregion
    }
}
