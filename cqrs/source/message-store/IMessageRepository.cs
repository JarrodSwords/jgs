using System.Collections.Generic;

namespace Jgs.Cqrs
{
    public interface IMessageRepository
    {
        IEnumerable<Event> Read(StreamId streamId);
        void Save(Event @event);
    }
}
