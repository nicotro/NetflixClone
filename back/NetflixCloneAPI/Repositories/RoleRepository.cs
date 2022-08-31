using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Role entity)
        {
            _dataContextService.Roles.Add(entity);
            return Update() && entity.Id > 0;
        }

        public override bool Delete(Role entity)
        {
            _dataContextService.Roles.Remove(entity);
            return Update() && entity.Id > 0;
        }

        public override Role Find(Func<Role, bool> predicate)
        {
            return _dataContextService.Roles.ToList().FirstOrDefault(c => predicate(c));
        }

        public override List<Role> FindAll(Func<Role, bool> predicate)
        {
            return _dataContextService.Roles.ToList().Where(f => predicate(f)).ToList();
        }

        /*--- Useless ! ---*/ 
        public override List<Role> FindByCategory(int category)
        {
            throw new NotImplementedException();
        }
    }
}
