using System.Collections.Generic;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Streams;

namespace Jgs.EventSourcing.Stores
{
    public interface IMessageStore
    {
        GlobalVersion GetGlobalVersion();
        StreamVersion GetStreamVersion(StreamId streamId);
        IEnumerable<Message> Read(StreamId streamId);
        IMessageStore Save(AggregateStreamId streamId, Event @event, StreamVersion expectedVersion = default);
        IMessageStore Save(CommandStreamId streamId, Command command, StreamVersion expectedVersion = default);
    }
}
