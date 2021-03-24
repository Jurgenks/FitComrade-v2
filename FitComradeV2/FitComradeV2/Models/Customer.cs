using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitComradeV2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAdress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string Payment { get; set; }

        public void RegisterCustomer(Customer customer)
        {

        }
        public void UpdateCustomerDetails(Customer customer)
        {

        }
        public void GetCustomerFromProfile(Profile profile)
        {

        }
    }
}
