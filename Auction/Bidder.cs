using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class Bidder
    {
        public int BidderID { get; set; }
        public string BidderName { get; set; }
        public int BidderBalance { get; set; }

        public Bidder(int Bidder, string BidderName, int BidderBalance)
        {
            this.BidderID = BidderID;
            this.BidderName = BidderName;
            this.BidderBalance = BidderBalance;
        }
    }
}
