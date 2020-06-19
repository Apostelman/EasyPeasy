using Microsoft.EntityFrameworkCore;

namespace EasyPeasyDataModel.Classes
{
    [Owned]
    public class PhoneNumber
    {

        public string Prefix { get; set; }
        public string Number { get; set; }
        public PhoneNumber(string prefix, string number)
        {
            Prefix = prefix;
            Number = number;
        }
    }
}
