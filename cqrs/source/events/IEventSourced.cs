using System.Collections.Generic;

namespace Jgs.Cqrs
{
    public interface IEventSourced
    {
        IReadOnlyList<Event> GetPendingEvents();
    }
}
