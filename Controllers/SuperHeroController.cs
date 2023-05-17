using Microsoft.AspNetCore.Mvc;
using SuperHero_.NET7.Models;
using SuperHero_.NET7.Services.SuperHeroServices;

namespace SuperHero_.NET7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return await _superHeroService.GetAllHeroes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var hero = _superHeroService.GetSingleHero(id);
            if (hero is null)
                return NotFound("Hero Not Found!");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddSuperHero(SuperHero superHero)
        {
            var hero = _superHeroService.AddSuperHero(superHero);
            return Ok(hero);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var hero = _superHeroService.UpdateHero(id, request);
            if (hero is null)
                return NotFound("Hero Not Found!");
            return Ok(hero);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var hero = _superHeroService.DeleteHero(id);
            if (hero is null)
                return NotFound("Hero Not Found!");
            return Ok(hero);
        }
    }
}