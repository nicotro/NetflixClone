using NetflixCloneEntity.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCloneEntity.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected DataContext _dataContext;

        protected BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public abstract bool Create(T element);

        public abstract bool Update();

        public abstract bool Delete(T element);


        public abstract T Find(Predicate<T> predicate);

        public abstract List<T> FindAll(Predicate<T> predicate);
    }
}
