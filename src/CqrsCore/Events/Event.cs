namespace CqrsCore.Events
{
    using System;

    public class Event : IEvent
    {
        public int Version;
        public Guid AggregateId { get; set; }
    }
}
