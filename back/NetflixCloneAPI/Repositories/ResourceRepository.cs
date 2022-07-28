using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class ResourceRepository : BaseRepository<Resource>
    {
        public ResourceRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Resource entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Resource entity)
        {
            throw new NotImplementedException();
        }

        public override Resource Find(Func<Resource, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Resource> FindAll(Func<Resource, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
