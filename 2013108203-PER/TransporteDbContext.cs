using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013108203_ENT;
using _2013108203_PER.EntitiesConfigurations;

namespace _2013108203_PER
{
    public class TransporteDbContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<LugarViaje> LugarViajes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public TransporteDbContext() : base("Transporte")
        {

        }

         

       
      
    }
}
