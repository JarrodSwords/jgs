using System.Collections.Generic;

namespace Jgs.Ddd
{
    public interface IMessageRepository
    {
        IEnumerable<Event> Read(StreamId streamId);
        void Save(Event @event);
    }
}
