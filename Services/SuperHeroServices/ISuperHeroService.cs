using SuperHero_.NET7.Models;

namespace SuperHero_.NET7.Services.SuperHeroServices
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        SuperHero? GetSingleHero(int id);
        List<SuperHero> AddSuperHero(SuperHero superHero);
        List<SuperHero>? UpdateHero(int id, SuperHero request);
        List<SuperHero>? DeleteHero(int id);
    }
}
