using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPeasyDataModel.Classes
{
    public class AddressAddressType
    {

        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        
    }
}
