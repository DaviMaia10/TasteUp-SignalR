using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class Basket
    {
        public int BasketId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }

        //one to many relation between basket and product
        public int ProductID { get; set; }
        public Product Product { get; set; }

        //one to many relation between basket and customerseat
        public int CustomerSeatId { get; set; }
        public CustomerSeat CustomerSeat { get; set; }
    }
}
