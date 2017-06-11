using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2013108203_ENT.IRepositories
{
    public interface IRepository<Tentity> where Tentity : class 
    {
        //CREATES
        void Add(Tentity entity);
        void AddRange(IEnumerable<Tentity> entities);

        //READS
        Tentity Get(int? Id);
        IEnumerable<Tentity> GetAll();

        IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> predicate);

        //UPDATES
        //void Update(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);

        //DELETES
        void Delete(Tentity entity);
        void DeleteRange(IEnumerable<Tentity> entities);

    }
}
