using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndData
{
    public class Repository<T> where T : class, IIdEntity
    {
        WinesDbContext ctx;
        public Repository(WinesDbContext ctx)
        {
            this.ctx = ctx;
        }

        public void Add(T entity)
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();
        }
        public void DeleteById(string id)
        {
            var entity = FindById(id);
            ctx.Set<T>().Remove(entity);
            ctx.SaveChanges();
        }
        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }
        public T FindById(string id)
        {
            return ctx.Set<T>().First(e => e.Id == id);
        }
    }
}
