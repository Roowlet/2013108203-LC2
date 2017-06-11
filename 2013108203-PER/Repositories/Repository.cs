using _2013108203_ENT.IRepositories;
using System.Data.Entity;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013108203_PER.Repositories
{
   public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
        protected readonly DbContext _Context;

        public Repository(DbContext context)
        {
            _Context = context;
        }

        public void Delete(Tentity entity)
        {
            _Context.Set<Tentity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<Tentity> entities)
        {
            _Context.Set<Tentity>().RemoveRange(entities);
        }

        public Tentity Get(int? id)
        {
            return _Context.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> GetAll()
        {
            return _Context.Set<Tentity>().ToList();
        }

        public IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> predicate)
        {
            return _Context.Set<Tentity>().Where(predicate);
        }

        public void Add(Tentity entity)
        {
            _Context.Set<Tentity>().Add(entity);
        }

        public void AddRange(IEnumerable<Tentity> entities)
        {
            _Context.Set<Tentity>().AddRange(entities);
        }
    }
}
