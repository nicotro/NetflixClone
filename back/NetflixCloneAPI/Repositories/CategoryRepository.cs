using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public override Category Find(Func<Category, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Category> FindAll(Func<Category, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
