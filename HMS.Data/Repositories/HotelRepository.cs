using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data.Repositories
{
    public class HotelRepository
    {
        public void CreateHotel(Hotel hotelObj)
        {
            using (var context = new HMSDbContext())
            {
                if (hotelObj.HotelId == 0)
                {
                    // Create
                    context.Hotels.Add(hotelObj);

                }
                else
                {
                    // Edit
                    var hotelInDb = context.Hotels.SingleOrDefault(p => p.HotelId == hotelObj.HotelId);

                    hotelInDb.HotelName = hotelObj.HotelName;
                    hotelInDb.HotelTotalFloors = hotelObj.HotelTotalFloors;
                    hotelInDb.HotelTotalRooms = hotelObj.HotelTotalRooms;
                    hotelInDb.HotelDescription = hotelObj.HotelDescription;  

                }
                context.SaveChanges();
            }
        }

        public ICollection<Hotel> GetHotels()
        {
            using (var context = new HMSDbContext())
            {
                return context.Hotels.AsNoTracking().ToList();
            }
        }
    }
}
