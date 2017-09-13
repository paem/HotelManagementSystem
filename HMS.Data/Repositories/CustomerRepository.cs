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
    }
}
