using System.Collections.Generic;

namespace Jgs.Ddd
{
    public interface IEventSourced
    {
        IReadOnlyList<Event> GetPendingEvents();
    }
}
