using System.Collections.Generic;

namespace EasyPeasyDataModel.Classes
{
    public class AddressType
    {
        public int AddressTypeID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AddressAddressType> AddressAddressTypes { get; set; } = new List<AddressAddressType>();

    }
}
