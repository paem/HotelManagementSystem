using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Models;
using System.Data.Entity;

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

                    roomInDb.RoomStatus = roomObj.RoomStatus;

                }
                context.SaveChanges();
            }
        }

        public void CreateRoomCategory(RoomCategory roomCategoryObj)
        {
            using (var context = new HMSDbContext())
            {
                if (roomCategoryObj.RoomCategoryId == 0)
                {
                    // Create
                    context.RoomCategory.Add(roomCategoryObj);

                }
                else
                {
                    // Edit
                    var roomCategoryInDb = context.RoomCategory.SingleOrDefault(p => p.RoomCategoryId == roomCategoryObj.RoomCategoryId);

                    roomCategoryInDb.RoomCount = roomCategoryObj.RoomCount;

                }
                context.SaveChanges();
            }
        }

        public ICollection<RoomCapacity> GetRoomCapacity()
        {
            using (var context = new HMSDbContext())
            {
                return context.RoomCapacity.AsNoTracking().ToList();
            }
        }

        public ICollection<RoomCategory> GetRoomCategoryTypes()
        {
            using (var context = new HMSDbContext())
            {
                return context.RoomCategory.AsNoTracking().ToList();
            }
        }

        public ICollection<Room> GetRoomByCategoryId(int RoomCategoryId)
        {
            using (var context = new HMSDbContext())
            {
               
                // Get room by category id
                return context.Rooms.Where(e => e.RoomCategoryId == RoomCategoryId).ToList();
            }
        }

        public ICollection<Room> GetRooms()
        {
            using (var context = new HMSDbContext())
            {
                context.Configuration.ProxyCreationEnabled = false;
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

        public Room FindRoomById(int roomId)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
                context.Configuration.ProxyCreationEnabled = false;
                return context.Rooms.AsNoTracking().SingleOrDefault(p => p.RoomId == roomId);
            }
        }

        public RoomCategory FindCategoryById(int categoryId)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.RoomCategory.AsNoTracking().SingleOrDefault(p => p.RoomCategoryId == categoryId);
            }
        }

        // Could be optimized 
        public ICollection<Room> RoomDetailInfoById(int id)
        {
            using (HMSDbContext context = new HMSDbContext())
            {
              context.Configuration.LazyLoadingEnabled = false;

              var query = context.Rooms.AsNoTracking().Where(p => p.RoomCategoryId == id).ToList(); 
              return query;
            }
        }

        public RoomCapacity FindCapacityById(int capacityId)
        {
            using (HMSDbContext context = new HMSDbContext())
            {         
                return context.RoomCapacity.AsNoTracking().SingleOrDefault(p => p.RoomCapacityId == capacityId);
            }
        }
    }
}
