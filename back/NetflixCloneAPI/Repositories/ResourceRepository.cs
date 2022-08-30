using Microsoft.EntityFrameworkCore;
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
            _dataContextService.Resources.Add(entity);
            return Update() && entity.Id > 0;
        }

        public override bool Delete(Resource entity)
        {
            throw new NotImplementedException();
        }

        public override Resource Find(Func<Resource, bool> predicate)
        {
            return _dataContextService.Resources
                .Include(r=>r.Genre_Resources)
                .Include(r => r.Images)
                .Include(r => r.Videos)
                .ToList().FirstOrDefault(a => predicate(a));
        }

        public override List<Resource> FindAll(Func<Resource, bool> predicate)
        {
            return _dataContextService.Resources
                .Include(r=>r.Genre_Resources)
                .Include(r => r.Images)
                .Include(r => r.Videos)
                .ToList().Where(a => predicate(a)).ToList();
        }
    }
}
