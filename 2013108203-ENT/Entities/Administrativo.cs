using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013108203_ENT
{
    public class Administrativo
    {

        public virtual int VentaId { get; set; }
        public virtual Venta Venta { get; set; }


        public Administrativo()
        {

        }
    }
}
