using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class Bid
    {
        public double DefaultBid { get; set; }
        public double CurrentBid { get; set; }

        public Bid(double DefaultBid, double CurrentBid)
        {
            this.DefaultBid = DefaultBid;
            this.CurrentBid = CurrentBid;
        }
    }

}
