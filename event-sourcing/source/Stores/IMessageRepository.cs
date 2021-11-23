using System.Collections.Generic;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Streams;

namespace Jgs.EventSourcing.Stores
{
    public interface IMessageRepository
    {
        bool Exists(Id messageId);
        bool Exists(StreamId streamId);
        IEnumerable<Message> Fetch(StreamId streamId);
        Message Find(Id messageId);
        GlobalVersion GetGlobalVersion();
        StreamVersion GetStreamVersion(StreamId streamId);
        IMessageRepository Save(Message message);
    }
}
