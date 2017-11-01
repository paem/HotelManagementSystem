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

        public Booking GetBookingById(int bookingId)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
                return context.Booking.AsNoTracking().SingleOrDefault(p => p.BookingId == bookingId);
            }
        }

        public ICollection<Booking> GetBookingByUserId(int id)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
                context.Configuration.ProxyCreationEnabled = false;
                return context.Booking.AsNoTracking().Where(e => e.CustomerId == id).ToList();


            }
        }

        // Could be optimized 
        public ICollection<Booking> BookingDetailInfoById(int id)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var query = context.Booking.AsNoTracking().Where(p => p.CustomerId == id).ToList();
                return query;
            }
        }

        public void DeleteBookingByBookingId(int bookingId)
        {
            using (var context = new HMSDbContext())
            {
                var bookingInDb = context.Booking.SingleOrDefault(e => e.BookingId == bookingId);
                context.Booking.Remove(bookingInDb);
                context.SaveChanges();
            }
        }
    }
}
