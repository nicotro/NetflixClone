using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class GenreResourceRepository : BaseRepository<Genre_resource>
    {
        public GenreResourceRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Genre_resource entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Genre_resource entity)
        {
            throw new NotImplementedException();
        }

        public override Genre_resource Find(Func<Genre_resource, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Genre_resource> FindAll(Func<Genre_resource, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
