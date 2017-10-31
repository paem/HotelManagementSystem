using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HMS.Models;
using System.IO;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml;

namespace HMS.Data.Repositories
{
    public class XmlRepository
    {
      public void LoadRooms()
        {
            using (var context = new HMSDbContext())
            {
                XDocument doc = XDocument.Load(@"C:\Users\Vidar\OneDrive\Dokument\GitHub\HotelManagementSystem\HMS.Data\Rooms.xml");


                var room = from c in doc.Descendants("Roomlist")
                           select new Room
                           {
                               RoomId = int.Parse(c.Element("roomId").Value),
                               RoomCapacityId = int.Parse(c.Element("capacityId").Value),
                               RoomCategoryId = int.Parse(c.Element("categoryId").Value),
                               RoomDoorNumber = int.Parse(c.Element("RoomDoorNumber").Value),
                               RoomPrice = double.Parse(c.Element("roomPrice").Value),
                               RoomStatus = bool.Parse(c.Element("roomStatus").Value)
                           };

                //context.Rooms.Add(room);


                //    using (XmlReader reader = XmlReader.Create(@"C: \Users\Vidar\OneDrive\Dokument\GitHub\HotelManagementSystem\HMS.Data\Rooms.xml"))
                //{
                //    while (reader.Read())
                //    {
                //        if (reader.HasAttributes)
                //        {
                //            for ()
                //            {


                //            }
                //        }



                //    }
                //}



                //var room = doc.Descendants("Roomlist").Select(el => new Room()
                //{
                //    RoomId = int.Parse(el.Element("RoomId").Value),
                //    RoomCapacityId = int.Parse(el.Element("capacityId").Value),
                //    RoomCategoryId = int.Parse(el.Element("categoryId").Value),
                //    RoomDoorNumber = int.Parse(el.Element("RoomDoorNumber").Value),
                //    RoomPrice = double.Parse(el.Element("roomPrice").Value),
                //    RoomStatus = bool.Parse(el.Element("roomStatus").Value),

                //});
                //  context.Rooms.Add(room);
                // Debug.WriteLine(room);
                //context.Rooms.Add(room);
                //foreach (var rooms in room)
                //{
                //    context.Rooms.Add(rooms);
                //    Debug.WriteLine(rooms);
                //Room newRoom = new Room
                //{
                //    //RoomDoorNumber = rooms,
                //    //RoomCapacityId = rooms,
                //    //RoomPrice = rooms,

                //};

                //}

                //Debug.WriteLine(room);



                //context.SaveChanges();
            }



        }

       


    }
}
