using System.Collections.Generic;

namespace Jgs.Cqrs
{
    public class SmartMessageStore : IMessageStore
    {
        private readonly IMessageRepository _messageRepository = new InMemoryMessageRepository();

        #region IMessageStore Implementation

        public void Publish(StreamId streamId, Event @event)
        {
            _messageRepository.Save(@event);
        }

        public IEnumerable<Event> Read(StreamId streamId) => _messageRepository.Read(streamId);

        #endregion
    }
}
