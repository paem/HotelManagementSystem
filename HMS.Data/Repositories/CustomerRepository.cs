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
    
        public ICollection<Customer> GetCustomers()
        {
            using (var context = new HMSDbContext())
            {
                return context.Customers.AsNoTracking().ToList();
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
                    customerInDb.CheckedIn = customerObj.CheckedIn;

                }
                context.SaveChanges();
            }
        }

        public Customer LoginUser(string Email, string Password)
        {
            using (HMSDbContext context = new HMSDbContext())
            {

               return context.Customers.Where(a => a.CustomerEmail.Equals(Email) && a.Password.Equals(Password)).FirstOrDefault();
                     
            }
        }

        public Customer GetUserByEmail(string Email)
        {
            using (HMSDbContext context = new HMSDbContext())
            {

                return context.Customers.Where(a => a.CustomerEmail.Equals(Email)).FirstOrDefault();

            }
        }

  

        public void SetCheckedIn(int userId)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
                context.Customers.SingleOrDefault(e => e.CustomerId == userId).CheckedIn = true;
                context.SaveChanges();
            }
        }

        public void SetCheckedOut(int userId)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
                context.Customers.SingleOrDefault(e => e.CustomerId == userId).CheckedIn = false;
                context.SaveChanges();
            }
        }
    }
}
