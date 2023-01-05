using SuperHeroGraphQL.Data;
using SuperHeroGraphQL.Interfaces;

namespace SuperHeroGraphQL.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}