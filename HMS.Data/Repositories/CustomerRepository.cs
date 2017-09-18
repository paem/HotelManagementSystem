using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Repositories
{
    public class CustomerRepository
    {
        public ICollection<CustomerDetails> GetCustomerDetails()
        {
            using (var context = new HMSDbContext())
            {
                return context.CustomerDetails.AsNoTracking().ToList();
            }
        }

        public void CreateUser(Customer customerObj)
        {
            using (var context = new HMSDbContext())
            {
                if (customerObj.CustomerId == 0)
                {
                    // Create
                    context.Customers.Add(customerObj);

                }
                else
                {
                    // Edit
                    var customerInDb = context.Customers.SingleOrDefault(p => p.CustomerId == customerObj.CustomerId);

                    customerInDb.CustomerEmail = customerObj.CustomerEmail;
                    customerInDb.CustomerPhoneNo = customerObj.CustomerPhoneNo;
                    customerInDb.CustomerAddress = customerObj.CustomerAddress;
                    customerInDb.CustomerCity = customerObj.CustomerCity;

                }
                context.SaveChanges();
            }
        }


    }
}
