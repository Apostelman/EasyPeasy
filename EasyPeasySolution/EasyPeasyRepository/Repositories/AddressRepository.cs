using EasyPeasyDataModel.Classes;
using EasyPeasyRepository.Interfaces;
using EasyPeasySQLService;
using System.Collections.Generic;
using System.Linq;

namespace EasyPeasyRepository.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(EasyPeasyContext context)
            : base(context)
        {
        }

        // Hier kommen Methoden, die speziell auf Projekte ausgelegt sind! ....

        //public IEnumerable<Address> GetAddressesWithProjects(IEnumerable<ProjectStateEnum> projectStates)
        //{
        //    return Context.Addresses
        //        .Include(a => a.Projects)
        //        .Where(a => a.Projects.Count > 0)
        //        .Where(a => a.Projects.Any(p => projectStates.Contains(p.IdProjectState.Value)));
        //}

        public IEnumerable<Address> SearchAddress(string search)
        {
            return _context.Addresses
                      .Where(a => a.LastName.Contains(search) || a.FirstName.Contains(search) || a.CompanyName.Contains(search));
        }
    }
}
