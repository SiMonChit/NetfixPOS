using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class CustomerController : ICustomer
    {
        private CustomerDAL _customer;
        private EventLogsController _eventLogs;
        public CustomerController()
        {
            _customer = new CustomerDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            try
            {
                _customer.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Customer Form", "Delete CustomerId " + id.ToString(), "Delete Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Customer Form", "Delete Customer", ex.Message);
            }
        }

        public void Insert(CustomerModel customer)
        {
            try
            {
                _customer.Insert(customer);
                _eventLogs.AddLog("Insert", DateTime.Now, "Customer Form", "Insert " + customer.CustomerName, "Insert Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Customer Form", "Insert Customer", ex.Message);
            }
        }

        public void Update(CustomerModel customer)
        {
            try
            {
                _customer.Update(customer);
                _eventLogs.AddLog("Update", DateTime.Now, "Customer Form", "Update Customer", "Update Success");
            }
            catch (Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Customer Form", "Update Customer", ex.Message);
            }
        }
        public DataRow GetDefaultCustomer()
        {
            return _customer.GetDefaultCustomer();
        }
        public DataTable GetCustomer(int id)
        {
            return _customer.GetCustomer(id);
        }
    }
}
