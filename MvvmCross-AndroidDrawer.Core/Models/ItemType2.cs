using System.Collections.Generic;

namespace MvvmCrossAndroidDrawer.Core.Models
{
    public class ItemType2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ItemType1> ItemType1List { get; set; }
    }
}