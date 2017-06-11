using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013108203_ENT.IRepositories;

namespace _2013108203_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly TransporteDbContext _Context;

        public _2013108203_ENT.IRepositories.IAdministrativoRepository Administrativos { get; private set; }

        public _2013108203_ENT.IRepositories.IBusRepository Buses { get; private set; }

        public _2013108203_ENT.IRepositories.IClienteRepository Clientes { get; private set; }

        public _2013108203_ENT.IRepositories.IEncomiendaRepository Encomiendas { get; private set; }

        public _2013108203_ENT.IRepositories.ILugarViajeRepository LugarViajes { get; private set; }

        public _2013108203_ENT.IRepositories.ITransporteRepository Transports { get; private set; }

        public _2013108203_ENT.IRepositories.ITripulacionRepository Tripulaciones { get; private set; }

        public _2013108203_ENT.IRepositories.IVentaRepository Ventas { get; private set; }

        private UnityOfWork()
        {
            _Context = new TransporteDbContext();

            Administrativos = new AdministrativoRepository(_Context);
            Buses = new BusRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Encomiendas = new EncomiendaRepository(_Context);
            LugarViajes = new LugarViajeRepository(_Context);
            Transports = new TransporteRepository(_Context);
            Tripulaciones = new TripulacionRepository(_Context);
            Ventas = new VentaRepository(_Context);
        }

      

      

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        int IUnityOfWork.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IUnityOfWork.StateModified(object Entity)
        {
            throw new NotImplementedException();
        }
    }
}
