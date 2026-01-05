using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class CustomerSeat
    {
        public int CustomerSeatId { get; set; }
        public string CustomerSeatName { get; set; }
        public bool Status { get; set; }

        //one to many relation with basket table
        public List<Basket> Baskets { get; set; }
    }
}
