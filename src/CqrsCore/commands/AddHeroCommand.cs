using System;

namespace CqrsCore.commands
{
    public class AddHeroCommand : Command
    {
        public Guid HeroId { get; set; }
        public string HeroName { get; set; }

        public AddHeroCommand(Guid aggregateId, int version, Guid heroId, string heroName) : base(aggregateId, version)
        {
            HeroId = heroId;
            HeroName = heroName;
        }
    }
}
