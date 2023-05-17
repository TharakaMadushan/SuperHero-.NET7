using SuperHero_.NET7.Models;

namespace SuperHero_.NET7.Services.SuperHeroServices
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetAllHeroes();
        Task<SuperHero?> GetSingleHero(int id);
        Task<List<SuperHero>> AddSuperHero(SuperHero superHero);
        Task<List<SuperHero>?> UpdateHero(int id, SuperHero request);
        Task<List<SuperHero>?> DeleteHero(int id);
    }   
}
