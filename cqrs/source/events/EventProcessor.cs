using System;
using System.Collections.Generic;

namespace Jgs.Cqrs
{
    public class EventProcessor : IEventSourced
    {
        private readonly Dictionary<Type, Action<Event>> _handlers = new();
        private readonly List<Event> _pendingEvents = new();

        #region Public Interface

        public EventProcessor Append(params Event[] events)
        {
            foreach (var e in events)
            {
                _handlers[e.GetType()].Invoke(e);
                _pendingEvents.Add(e);
            }

            return this;
        }

        public EventProcessor Register<T>(Action<T> handler = default) where T : Event
        {
            handler ??= _ => { };

            _handlers.Add(typeof(T), e => handler((T) e));
            return this;
        }

        public EventProcessor Replay(params Event[] events)
        {
            foreach (var e in events)
                _handlers[e.GetType()].Invoke(e);

            return this;
        }

        #endregion

        #region IEventSourced Implementation

        public IReadOnlyList<Event> GetPendingEvents() => _pendingEvents.AsReadOnly();

        #endregion
    }
}
