using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Models;

namespace HMS.Data.Repositories
{
    public class RoomRepository
    {
        public void CreateRoom(Room roomObj)
        {
            using (var context = new HMSDbContext())
            {
                if (roomObj.RoomId == 0)
                {
                    // Create
                    context.Rooms.Add(roomObj);
         
                }
                else
                {
                    // Edit
                    var roomInDb = context.Rooms.SingleOrDefault(p => p.RoomId == roomObj.RoomId);

                    roomInDb.RoomDoorNumber = roomObj.RoomDoorNumber;
                    roomInDb.RoomCount = roomObj.RoomCount;
                    roomInDb.RoomStatus = roomObj.RoomStatus;
                    roomInDb.RoomCategoryId = roomObj.RoomCategoryId;

                }
                context.SaveChanges();
            }
        }

        public ICollection<Room> GetRooms()
        {
            using (var context = new HMSDbContext())
            {
                return context.Rooms.AsNoTracking().ToList();
            }
        } 

        public void DeleteRoomById(int roomId)
        {
            using (var context = new HMSDbContext())
            {      
                var roomInDb = context.Rooms.SingleOrDefault(e => e.RoomId == roomId);
                context.Rooms.Remove(roomInDb);
                context.SaveChanges();
            }
        }
    }
}
