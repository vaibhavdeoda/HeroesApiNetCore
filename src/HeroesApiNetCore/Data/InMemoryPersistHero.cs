using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Data
{
    public class InMemoryPersistHero : IPersistHero
    {
        List<Hero> _heroes;
        private const string Cache = "HeroesCache";
        public InMemoryPersistHero()
        {
            _heroes = new List<Hero> { new Hero { Id = 1, Name = "Bombasta" }, new Hero { Id = 2, Name = "Superman" } };
        }

        public IEnumerable<Hero> GetHeroes()
        {
            return _heroes;
        }

        public Hero GetHeroById(int id)
        {
            return _heroes.FirstOrDefault(x => x.Id == id);
        }

        public void SaveHero(string name)
        {
            _heroes?.Add(new Hero { Id = _heroes.Count() + 1, Name = name });
        }

        public void DeleteHero(int id)
        {
            
            _heroes?.Remove(_heroes?.FirstOrDefault(x => x.Id == id));
        }
    }
}
