using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrudFullStack.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorCrudFullStack.Server.Controllers
{
    [Route("api/[controller]")] //     [Route("api/[controller]")] = api/<ControllerName Before word Controller , i.e. /api/SuperHero]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        public static List<Comic> comics = new List<Comic>
        {
            new Comic { Id = 1, Name = "Marvel"},
            new Comic { Id = 2, Name = "DC"}
        };

        public static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero { Id = 1, FirstName = "Peter", LastName = "Parker", HeroName = "SpiderMan", Comic = comics[0] },
            new SuperHero { Id = 2, FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman", Comic = comics[1] }
        };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            return Ok(superHeroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSuperHeroById(int id)
        {
            var hero = superHeroes.FirstOrDefault(data => data.Id == id);
            if (hero == null)
            {
                return NotFound("Sorry, hero not found by that id....");
            }
            return Ok(hero);
        }

    }
}

