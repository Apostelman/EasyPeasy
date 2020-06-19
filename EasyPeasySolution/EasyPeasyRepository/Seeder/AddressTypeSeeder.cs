using EasyPeasyDataModel.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPeasyRepository.Seeder
{
    public static class AddressTypeSeeder
    {
        public static void Seed()
        {
            using (var u = new UnitOfWork())
            {
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Privatperson"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Unternehmen"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Einzelunternehmen"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Verein"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Behörde / Institution"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Mitarbeiter"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Freier Mitarbeiter"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Verleiher"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Produktionsfirma"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Fernsehsender"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Technischer Dienstleister"
                });
                u.AddressesTypes.Add(new AddressType()
                {
                    Name = "Lieferant"
                });
                u.Save();
            }
        }
    }
}
