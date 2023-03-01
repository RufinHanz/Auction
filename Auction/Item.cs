using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class Item
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }

        public Item(string ItemName, string ItemDescription)
        {
            this.ItemName = ItemName;
            this.ItemDescription = ItemDescription;
        }
    }
}
