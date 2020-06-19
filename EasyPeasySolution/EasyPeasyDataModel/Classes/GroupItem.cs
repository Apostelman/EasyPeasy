using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPeasyDataModel.Classes
{
    public class GroupItem
    {
        public ulong ID { get; set; }
        public Group Parent { get; set; }
        public string Name { get; set; }
        public uint SortOrder { get; set; }
        public float Factor { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
