using Microsoft.EntityFrameworkCore;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(User entity)
        {
            _dataContextService.Users.Add(entity);
            return Update() && entity.Id > 0;
        }

        public override bool Delete(User entity)
        {
            _dataContextService.Users.Remove(entity);
            return Update() && entity.Id > 0;
        }

        public override User Find(Func<User, bool> predicate)
        {
            return _dataContextService.Users
                .Include(u => u.Role)
                .ToList().FirstOrDefault(u => predicate(u));
        }

        public override List<User> FindAll(Func<User, bool> predicate)
        {
            return _dataContextService.Users.ToList().Where(u => predicate(u)).ToList();
        }
    }
}
