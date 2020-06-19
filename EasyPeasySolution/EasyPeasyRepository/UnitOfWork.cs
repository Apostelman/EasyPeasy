using EasyPeasyRepository.Interfaces;
using EasyPeasyRepository.Repositories;
using EasyPeasySQLService;
using System;

namespace EasyPeasyRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        // Der Context wird hier für die Lebenszeit der UoW beibehalten
        private readonly EasyPeasyContext _context;
        private bool _disposed;

        public UnitOfWork()
        {
            // Initialisiere den Context und die Repos
            _context = new EasyPeasyContext();
            //_context.Configuration.LazyLoadingEnabled = false;

            Addresses = new AddressRepository(_context);
            AddressesTypes = new AddressTypeRepository(_context);
        }

        // Stellt alle Entities via deren Repos als Property zur Verfügung

        public IAddressRepository Addresses { get; }
        public IAddressTypeRepository AddressesTypes { get; }




        // Speichere alle Änderungen die in der UoW aufgetreten sind
        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                    // Dispose other managed resources.
                }
                //release unmanaged resources.
            }
            _disposed = true;
        }
    }
}