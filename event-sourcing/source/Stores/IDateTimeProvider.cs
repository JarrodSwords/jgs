using System;

namespace Jgs.EventSourcing.Stores
{
    public interface IDateTimeProvider
    {
        DateTime GetUtcNow();
    }
}
