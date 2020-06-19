using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPeasyDataModel.Classes
{
    public class Job
    {
        public uint ID { get; set; }
        public Job Parent { get; set; }
        public string Name { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Discount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
