using SuperHeroGraphQL.Data;
using SuperHeroGraphQL.Models;

namespace SuperHeroGraphQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([ScopedService] ApplicationDbContext context) =>
            context.Superheroes;
    }
}