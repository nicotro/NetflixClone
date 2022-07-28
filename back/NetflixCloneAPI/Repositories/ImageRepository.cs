using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class ImageRepository : BaseRepository<Image>
    {
        public ImageRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Image entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Image entity)
        {
            throw new NotImplementedException();
        }

        public override Image Find(Func<Image, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Image> FindAll(Func<Image, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
