using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class CategoryResourceRepository : BaseRepository<Category_resource>
    {
        public CategoryResourceRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Category_resource entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Category_resource entity)
        {
            throw new NotImplementedException();
        }

        public override Category_resource Find(Func<Category_resource, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Category_resource> FindAll(Func<Category_resource, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
