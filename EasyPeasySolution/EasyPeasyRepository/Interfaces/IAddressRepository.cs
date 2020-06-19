using EasyPeasyDataModel.Classes;
using System.Collections.Generic;

namespace EasyPeasyRepository.Interfaces
{
    public interface IAddressRepository : IRepository<Address>
    {
        //IEnumerable<Address> GetAddressesWithProjects(IEnumerable<ProjectStateEnum> projectStates);
        IEnumerable<Address> SearchAddress(string search);
    }
}
