using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyPeasyDataModel.Classes
{
    public class Address
    {
        

        public int AddressID { get; set; }
        public virtual ICollection<AddressAddressType> AddressAddressTypes { get; set; } = new List<AddressAddressType>();

        
        public string CompanyName { get; set; }
        public string CompanyNameAddition { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        //public Country Country { get; set; }
        public virtual PhoneNumber PhoneLandline { get; set; }
        public virtual PhoneNumber PhoneMobile { get; set; }
        public virtual PhoneNumber Fax { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }



        public string GetName()
        {
            return CompanyName + FirstName + LastName;
        }
    }
}
