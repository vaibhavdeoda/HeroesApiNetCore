namespace CqrsCore.Events
{
    using System;

    public class HeroAddedEvent : Event
    {
        public HeroAddedEvent(Guid aggregateId,string heroName, Guid heroId)
        {
            AggregateId = aggregateId;
            HeroName = heroName;
            HeroId = heroId;
        }

        public Guid HeroId { get; private set; }
        public string HeroName { get; private set; }

    }
}
