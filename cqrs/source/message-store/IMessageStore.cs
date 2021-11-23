using System.Collections.Generic;

namespace Jgs.Cqrs
{
    public interface IMessageStore
    {
        void Publish(StreamId streamId, Event @event);
        IEnumerable<Event> Read(StreamId streamId);
    }
}
