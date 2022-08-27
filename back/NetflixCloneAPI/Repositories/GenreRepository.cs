using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class GenreRepository : BaseRepository<Genre>
    {
        public GenreRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Genre entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Genre entity)
        {
            throw new NotImplementedException();
        }

        public override Genre Find(Func<Genre, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Genre> FindAll(Func<Genre, bool> predicate)
        {
            return _dataContextService.Genres.ToList().Where(g => predicate(g)).ToList();
        }
    }
}
