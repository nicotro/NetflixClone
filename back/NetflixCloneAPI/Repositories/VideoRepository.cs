using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class VideoRepository : BaseRepository<Video>
    {
        public VideoRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Video entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Video entity)
        {
            throw new NotImplementedException();
        }

        public override Video Find(Func<Video, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Video> FindAll(Func<Video, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
