﻿using System;

namespace EventStoreService
{
    public interface IEvent
    {
        Guid Id { get; set; }
        int Version { get; set; }
        DateTimeOffset TimeStamp { get; set; }
    }
}
