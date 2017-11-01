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
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adpter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                XmlReader xmlFile;
                string sql = null;

                int roomId = 0;
                int roomCategoryId = 0;
                int capacityId = 0;
                int RoomDoorNumber = 0;
                double RoomPrice = 0;
                bool RoomStatus = false;

                connetionString = @"Data Source=PATRIKDATA\SQLEXPRESS;Initial Catalog=HotelManagementDb;Integrated Security=True";

                connection = new SqlConnection(connetionString);

                xmlFile = XmlReader.Create(@"C:\Users\Patrik\Documents\GitHub\HotelManagementSystem\HMS.Data\Rooms.xml", new XmlReaderSettings());
                ds.ReadXml(xmlFile);
                int i = 0;
                connection.Open();
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    roomId = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);
                    RoomDoorNumber = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[1]);                
                    RoomStatus = Convert.ToBoolean(ds.Tables[0].Rows[i].ItemArray[2]);
                    roomCategoryId = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3]);
                    RoomPrice = Convert.ToDouble(ds.Tables[0].Rows[i].ItemArray[4]);            
                    capacityId = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[5]);
                    sql = "SET IDENTITY_INSERT Rooms ON; INSERT INTO Rooms (RoomId, RoomDoorNumber, RoomStatus, RoomCategoryId, RoomPrice, RoomCapacityId) " +
                    "VALUES (" + "'" + roomId + "','" + RoomDoorNumber + "','" + RoomStatus + "','" + roomCategoryId + "','" + RoomPrice + "','" + capacityId + "'" + "); SET IDENTITY_INSERT Rooms OFF;";          
                    command = new SqlCommand(sql, connection);
                    adpter.InsertCommand = command;
                    adpter.InsertCommand.ExecuteNonQuery();
                }
                connection.Close();                      
        }
        public void LoadCategories()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adpter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            string sql = null;

            string RoomCategoryName = null;
            string RoomCategoryDesc = null;
            string RoomCategoryBeds = null;
            int RoomCapacityId = 0;
            string RoomCategoryImage = null;
            float RoomCount = 0;
            int RoomCategoryId = 0;
          

            connetionString = @"Data Source=PATRIKDATA\SQLEXPRESS;Initial Catalog=HotelManagementDb;Integrated Security=True";

            connection = new SqlConnection(connetionString);

            xmlFile = XmlReader.Create(@"C:\Users\Patrik\Documents\GitHub\HotelManagementSystem\HMS.Data\Categories.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            int i = 0;
            connection.Open();
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                RoomCategoryId = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);
                RoomCategoryName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                RoomCategoryDesc = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                RoomCategoryBeds = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                RoomCapacityId = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[4]);
                RoomCategoryImage = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                RoomCount = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[6]);            
                sql = "SET IDENTITY_INSERT RoomCategories ON; INSERT INTO RoomCategories (RoomCategoryId, RoomCategoryName, RoomCategoryDesc, RoomCategoryBeds, RoomCapacityId, RoomCategoryImage, RoomCount) " +
                    "VALUES (" + "'" + RoomCategoryId + "','" + RoomCategoryName + "','" + RoomCategoryDesc + "','" + RoomCategoryBeds + "','" + RoomCapacityId + "','" + RoomCategoryImage + "','" + RoomCount + "'" + "); SET IDENTITY_INSERT RoomCategories OFF;";
                command = new SqlCommand(sql, connection);
                adpter.InsertCommand = command;
                adpter.InsertCommand.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void LoadCapacities()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adpter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            string sql = null;

            int RoomCapacityId = 0;
            string RoomCapacityName = null;
            int RoomCapacityAdults = 0;
            int RoomCapacityChildren = 0;
 
            connetionString = @"Data Source=PATRIKDATA\SQLEXPRESS;Initial Catalog=HotelManagementDb;Integrated Security=True";

            connection = new SqlConnection(connetionString);

            xmlFile = XmlReader.Create(@"C:\Users\Patrik\Documents\GitHub\HotelManagementSystem\HMS.Data\Capacities.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            int i = 0;
            connection.Open();
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                RoomCapacityId = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);  
                RoomCapacityName = ds.Tables[0].Rows[i].ItemArray[1].ToString();             
                RoomCapacityAdults = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[2]);        
                RoomCapacityChildren = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3]);                    
                sql = "SET IDENTITY_INSERT RoomCapacities ON; INSERT INTO RoomCapacities (RoomCapacityId, RoomCapacityName, RoomCapacityAdults, RoomCapacityChildren) VALUES (" + "'" + RoomCapacityId + "','" + RoomCapacityName + "','" + RoomCapacityAdults + "','" + RoomCapacityChildren + "'" + "); SET IDENTITY_INSERT RoomCapacities OFF;";           
                command = new SqlCommand(sql, connection);
                adpter.InsertCommand = command;
                adpter.InsertCommand.ExecuteNonQuery();
            }
            connection.Close();
        }

    }
}
