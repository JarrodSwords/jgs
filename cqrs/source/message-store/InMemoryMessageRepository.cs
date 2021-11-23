using System.Collections.Generic;

namespace Jgs.Cqrs
{
    public class InMemoryMessageRepository : IMessageRepository
    {
        private readonly List<Event> _events = new();

        #region IMessageRepository Implementation

        public IEnumerable<Event> Read(StreamId streamId) => _events;

        public void Save(Event @event)
        {
            _events.Add(@event);
        }

        #endregion
    }
}
