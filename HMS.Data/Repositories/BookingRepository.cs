using HMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Repositories
{
    public class BookingRepository
    {
        public void CreateBooking(Booking bookObj)
        {
            using (var context = new HMSDbContext())
            {
                if (bookObj.BookingId == 0)
                {
                    // Create
                    context.Booking.Add(bookObj);               
                }
                else
                {
                    // Edit
                    var bookInDb = context.Booking.SingleOrDefault(p => p.BookingId == bookObj.BookingId);

                    bookInDb.BookingArrivalDate = bookObj.BookingArrivalDate;
                   
                   // bookInDb. = bookObj.;
                  //  bookInDb. = bookObj.;
                 //   bookInDb. = bookObj.;

                }
                context.SaveChanges();
            }
        }

        public ICollection<Booking> GetBookingStatus()
        {
            using (var context = new HMSDbContext())
            {
                return context.Booking.AsNoTracking().ToList();
            }
        }

        public ICollection<Booking> GetBookingByUserId(int id)
        {
            using (HMSDbContext context = new HMSDbContext())
            {

                return context.Booking.Where(a => a.CustomerId.Equals(id)).ToList();

            }
        }

        // Could be optimized 
        public ICollection<Booking> BookingDetailInfoById(int id)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var query = context.Booking.AsNoTracking().Where(p => p.CustomerId == id)
                                                             .Include(m => m.RoomCategories)
                                                             .Include(r => r.RoomCapacities)
                                                             .Include(a => a.Rooms)
                                                             .ToList();


                return query;
            }
        }
    }
}
