using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data.Repositories
{
    public abstract class BaseRepository<TEntity>
        where TEntity: class
    {
        protected Context Context { get; private set; }
        //base repository context constructor
        public BaseRepository(Context context)
        {
            Context = context;
        }
        //get all in DB set
        public abstract TEntity Get(int id);
        //Get(id) in DB set
        public abstract IList<TEntity> GetList();
        //INsert(entity)
        public void Insert(TEntity entity)
        {

            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }
        //Delete(id)
        public void Delete(int id)
        {
            var set = Context.Set<TEntity>();
            var entity = set.Find(id);
            set.Remove(entity);
            Context.SaveChanges();
        }
        //Update(entity)
        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
