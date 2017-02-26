using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Data
{
    public class PostgresPersistHero : IPersistHero
    {
        readonly HeroDbContext _dbContext;
        public PostgresPersistHero(HeroDbContext dbContext )
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Hero> GetHeroes()
        {
            
                return _dbContext.Heroes.Where(x => x.Active == 1).ToList();
        }

        public Hero GetHeroById(int id)
        {
            
                return _dbContext.Heroes.FirstOrDefault(x => x.Active == 1 && x.Id == id);
                
        }

        public void SaveHero(string name)
        {
                _dbContext.Heroes.Add(new Hero {Name = name, Active = 1});
                _dbContext.SaveChanges();
        }

        public void DeleteHero(int id)
        {
            
                var hero = _dbContext.Heroes.FirstOrDefault(x => x.Id == id);
                if (hero != null)
                {
                    if (hero.Active == 1)
                    {
                        hero.Active = 0;
                        _dbContext.SaveChanges();
                    }
                }
            }
        }
    }
