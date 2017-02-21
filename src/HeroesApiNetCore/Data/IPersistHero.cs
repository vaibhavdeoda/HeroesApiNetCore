using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    using System.Collections.Generic;

    public interface IPersistHero
    {
        IEnumerable<Hero> GetHeroes();
        Hero GetHeroById(int id);
        void SaveHero(string name);
        void DeleteHero(int id);
    }
}
