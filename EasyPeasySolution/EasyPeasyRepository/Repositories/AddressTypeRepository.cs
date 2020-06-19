using EasyPeasyDataModel.Classes;
using EasyPeasyRepository.Interfaces;
using EasyPeasySQLService;
using System.Collections.Generic;
using System.Linq;

namespace EasyPeasyRepository.Repositories
{
    public class AddressTypeRepository : Repository<AddressType>, IAddressTypeRepository
    {
        public AddressTypeRepository(EasyPeasyContext context)
            : base(context)
        {
        }

        // Hier kommen Methoden, die speziell auf Projekte ausgelegt sind! ....

        

        
    }
}
