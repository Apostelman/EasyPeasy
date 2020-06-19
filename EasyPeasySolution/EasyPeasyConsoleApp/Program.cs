using EasyPeasyDataModel.Classes;
using EasyPeasyRepository;
using EasyPeasyRepository.Seeder;
using System;

namespace EasyPeasyConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //AddressTypeSeeder.Seed();
            //AddressSeeder.Seed();
            using (var u = new UnitOfWork())
            {
                var addresses = u.Addresses.GetAll();
                Console.WriteLine("Addresses: ++++++++++++++++++++++++");
                foreach (var address in addresses)
                {
                    Console.WriteLine(address.GetName());
                }

                var addressTypes = u.AddressesTypes.GetAll();
                Console.WriteLine("AddressTypes: ++++++++++++++++++++++++");
                foreach (var addressType in addressTypes)
                {
                    Console.WriteLine(addressType.Name);
                }
                Console.WriteLine("Relations: +++++++++++++++++++++++++");
                var address1 = u.Addresses.Get(2);
                var address2 = u.Addresses.Get(3);
                var address3 = u.Addresses.Get(4);

                var addressType1 = u.AddressesTypes.Get(3);
                var addressType2 = u.AddressesTypes.Get(5);
                var addressType3 = u.AddressesTypes.Get(7);
                

                foreach (var addressAddressType in address1.AddressAddressTypes)
                {
                    Console.WriteLine(addressAddressType.AddressType.Name);
                }


            }
            Console.ReadLine();
        }
    }
}
