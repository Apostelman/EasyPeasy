using System;
using EasyPeasyRepository.Interfaces;

namespace EasyPeasyRepository
{
    public interface IUnitOfWork : IDisposable
    {
        // Hier m�ssen alle Repos aufgelistet werden ...
        IAddressRepository Addresses { get; }
        IAddressTypeRepository AddressesTypes { get; }


        int Save();
    }
}