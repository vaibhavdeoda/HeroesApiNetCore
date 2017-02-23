namespace CqrsCore.Domain
{
    using System.Collections.Generic;
    using Events;

    public abstract class AggregateRoot
    {
        private readonly List<Event> _events;

        public int Version { get; internal set; }
        public int EventVersion { get; protected set; }

        protected AggregateRoot()
        {
            _events = new List<Event>();
        }

        public IEnumerable<Event> UncommitedEvents()
        {
            return _events;
        }

        public void CommitEvents()
        {
            _events.Clear();
        }
    }
}
