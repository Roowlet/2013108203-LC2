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
        //C REATES
        // Agrega un registro al repositorio (SQL SERVER) a la tabla Tentity
        void Add(Tentity entity);
        // Agrega un registro al repositorio (SQL SERVER) a la tabla Tentity
        void AddRange(IEnumerable<Tentity> entities);


        //R EADS
        //Obtiene el  Registro con Primary Key = Id de la tabla Tentity
        Tentity Get(int Id);
        //Obtiene todos los registros de la tabla Tentity
        IEnumerable<Tentity> GetAll();
        //Obtiene todos los registros de la tabla Tentity que cumpla con la condiciòn predicate
        IEnumerator<Tentity> Find(Expression<Func<Tentity, bool>> predicate);


        //U PDATES

        void Update(Tentity entity);

        void UpdateRange(IEnumerable<Tentity> entities);


        //D ELATES

        void Delete(Tentity entity);

        void DeleteRange(IEnumerable<Tentity> entities);
    }
}
