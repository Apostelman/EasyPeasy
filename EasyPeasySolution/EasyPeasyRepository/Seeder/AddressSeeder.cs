using EasyPeasyDataModel.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPeasyRepository.Seeder
{
    public static class AddressSeeder
    {
        public static void Seed()
        {
            using (var u = new UnitOfWork())
            {
                //u.Addresses.Add(new Address()
                //{
                //    CompanyName = "LFB - Lichtforum Berlin GmbH",
                //    Street = "Ackerstr. 93",
                //    Zip = "13355",
                //    City = "Berlin",
                //    PhoneLandline = new PhoneNumber("030", "29361830"),
                //    Fax = new PhoneNumber("030", "29361850"),
                //    EmailAddress = "info@lichtforum.de",
                //    Website = "http://www.lichtforum.de",
                    
                //});
                u.Addresses.Add(new Address()
                {
                    CompanyName = "Multimedia Komplettservice",
                    FirstName = "Simon",
                    LastName = "Rossmann",
                    Street = "Simon-Dach-Str. 19",
                    Zip = "10245",
                    City = "Berlin",
                    PhoneLandline = new PhoneNumber("030", "70080700"),
                    PhoneMobile = new PhoneNumber("0175", "29361850"),
                    EmailAddress = "apostelman@gmx.de",
                    Website = "http://www.simonrossmann.de",

                });
                u.Addresses.Add(new Address()
                {
                    CompanyName = "Hans Wurst AG",
                    Street = "Kreuzweide 5",
                    Zip = "64421",
                    City = "Belamin",
                    PhoneLandline = new PhoneNumber("030", "7891120"),
                    PhoneMobile = new PhoneNumber("0175", "28896350"),
                    EmailAddress = "lac_cerda@yahoo.de",
                    Website = "http://www.google.de",

                });
                u.Save();
            }
        }
    }
}
