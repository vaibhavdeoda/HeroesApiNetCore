using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        private readonly IPersistHero _persistHero;
        public HeroesController(IPersistHero persistHero)
        {
            _persistHero = persistHero;
        }

        [HttpGet]
        public IEnumerable<Hero> GetAllHeroes()
        {
            return _persistHero.GetHeroes();
        }

        [HttpGet("{id}")]
        public Hero GetHero(int id)
        {
            return _persistHero.GetHeroById(id);
        }

        [HttpDelete("{id}")]
        public void DeleteHero(int id)
        {
            _persistHero.DeleteHero(id);
        }

        [HttpPost]
        public void PostHero([FromBody]PostHeroContract name)
        {
            _persistHero.SaveHero(name.HeroName);
        }
    }
    public class PostHeroContract
    {
        public string HeroName { get; set; }
    }
}
