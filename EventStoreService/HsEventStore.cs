using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace EventStoreService
{
    public class HsEventStore : IEventStore
    {
        public List<HsGamePlayedEvent> Events { get; set; }

        public HsEventStore(
            string eventFile)
        {
            // load a JSON file    

            using (var r = new StreamReader(eventFile))
            {
                var json = r.ReadToEnd();
                Events = JsonConvert.DeserializeObject<List<HsGamePlayedEvent>>(json);
            }
        }

        //  Get all events for a specific aggregate (order by version)
        public IEnumerable<IEvent> Get<T>(Guid aggregateId, int fromVersion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEvent> Get<T>(string eventType)
        {
            return Events;
        }
    }
}
