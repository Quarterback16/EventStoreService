using System;
using System.Collections.Generic;


namespace EventStoreService
{
    public interface IEventStore
    {
        IEnumerable<IEvent> Get<T>(Guid aggregateId, int fromVersion);
        IEnumerable<IEvent> Get<T>(string eventType);
    }
}
