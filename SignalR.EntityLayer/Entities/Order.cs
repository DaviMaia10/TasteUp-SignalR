using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string SeatNumber { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        //one to many relation with orderdetail table 
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
