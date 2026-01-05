using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface ICustomerSeatService : IGenericService<CustomerSeat>
    {
        int TCustomerSeatCount();
        void TChangeCustomerSeatStatusToTrue(int id);
        void TChangeCustomerSeatStatusToFalse(int id);
    }
}
