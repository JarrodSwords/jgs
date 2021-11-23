using System.Collections.Generic;

namespace Jgs.Ddd
{
    public interface IMessageStore
    {
        void Publish(StreamId streamId, Event @event);
        IEnumerable<Event> Read(StreamId streamId);
    }
}
