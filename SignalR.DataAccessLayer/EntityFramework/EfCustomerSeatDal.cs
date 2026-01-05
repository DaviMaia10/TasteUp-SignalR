using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfCustomerSeatDal : GenericRepository<CustomerSeat>, ICustomerSeatDal
    {
        public EfCustomerSeatDal(SignalRContext context) : base(context)
        {
        }

        public void ChangeCustomerSeatStatusToFalse(int id)
        {
            var context = new SignalRContext();
            var value = context.CustomerSeats.Where(x => x.CustomerSeatId == id).FirstOrDefault();
            value.Status = false;
            context.SaveChanges();
        }

        public void ChangeCustomerSeatStatusToTrue(int id)
        {
            var context = new SignalRContext();
            var value = context.CustomerSeats.Where(x => x.CustomerSeatId == id).FirstOrDefault();
            value.Status = true;
            context.SaveChanges();
        }

        public int CustomerSeatCount()
        {
            var context = new SignalRContext();
            return context.CustomerSeats.Count();
        }
    }
}
