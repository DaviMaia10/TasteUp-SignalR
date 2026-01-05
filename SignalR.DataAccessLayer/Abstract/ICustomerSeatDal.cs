using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface ICustomerSeatDal : IGenericDal<CustomerSeat>
    {
        int CustomerSeatCount();
        void ChangeCustomerSeatStatusToTrue(int id);
        void ChangeCustomerSeatStatusToFalse(int id);
    }
}
