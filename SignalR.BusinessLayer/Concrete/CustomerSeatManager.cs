using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class CustomerSeatManager : ICustomerSeatService
    {
        private readonly ICustomerSeatDal _customerSeatDal;

        public CustomerSeatManager(ICustomerSeatDal customerSeatDal)
        {
            _customerSeatDal = customerSeatDal;
        }

        public void TAdd(CustomerSeat entity)
        {
            _customerSeatDal.Add(entity);
        }

        public void TChangeCustomerSeatStatusToFalse(int id)
        {
            _customerSeatDal.ChangeCustomerSeatStatusToFalse(id);
        }

        public void TChangeCustomerSeatStatusToTrue(int id)
        {
            _customerSeatDal.ChangeCustomerSeatStatusToTrue(id);
        }

        public int TCustomerSeatCount()
        {
            return _customerSeatDal.CustomerSeatCount();
        }

        public void TDelete(CustomerSeat entity)
        {
            _customerSeatDal.Delete(entity);
        }

        public CustomerSeat TGetByID(int id)
        {
            return _customerSeatDal.GetByID(id);
        }

        public List<CustomerSeat> TGetListAll()
        {
            return _customerSeatDal.GetListAll();
        }

        public void TUpdate(CustomerSeat entity)
        {
            _customerSeatDal.Update(entity);
        }
    }
}
