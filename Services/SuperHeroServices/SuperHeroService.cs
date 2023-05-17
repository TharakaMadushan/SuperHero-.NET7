using Microsoft.EntityFrameworkCore;
using SuperHero_.NET7.Data;
using SuperHero_.NET7.Models;

namespace SuperHero_.NET7.Services.SuperHeroServices
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Name = "Test",
                FirstName = "Test",
                LastName = "Test",
                Place = ""
            }
        };
        private readonly DataContext _context;

        public SuperHeroService(DataContext context)
        {
            _context = context;
        }

        public List<SuperHero> AddSuperHero(SuperHero superHero)
        {
            superHeroes.Add(superHero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
                return null;
            superHeroes.Remove(hero);
            return superHeroes;
        }

        public async Task<List<SuperHero>> GetAllHeroes()
        {
            var superHeroes = await _context.SuperHeroes.ToListAsync();
            return superHeroes;
        }

        public SuperHero? GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;
            return hero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            return superHeroes;
        }
    }
}