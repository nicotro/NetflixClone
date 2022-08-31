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
            _dataContextService.Genres.Add(entity);
            return Update() && entity.Id > 0;
        }

        public override bool Delete(Genre entity)
        {
            throw new NotImplementedException();
        }

        public override Genre Find(Func<Genre, bool> predicate)
        {
            return _dataContextService.Genres.ToList().FirstOrDefault(g => predicate(g));
        }

        public override List<Genre> FindAll(Func<Genre, bool> predicate)
        {
            return _dataContextService.Genres.ToList().Where(g => predicate(g)).ToList();
        }

        public override List<Genre> FindByCategory(int category)
        {
            throw new NotImplementedException();
        }
    }
}
