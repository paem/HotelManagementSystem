using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Models;

namespace HMS.Data.Repositories
{
    class RoomRepository
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
                    var rooomInDb = context.Rooms.SingleOrDefault(p => p.RoomId == roomObj.RoomId);

                   
                }
                context.SaveChanges();
            }
        }


    }
}
