namespace HMS.Data
{
    using System.Data.Entity;
    using HMS.Models;

    public class HMSDbContext : DbContext
    {
        // Your context has been configured to use a 'HotelManagementModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'HMS.Data.HotelManagementModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HotelManagementModel' 
        // connection string in the application configuration file.

        //LOKALA Datorer = Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagementDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

        //Patriks Dator = Data Source=PATRIKDATA\SQLEXPRESS;Initial Catalog=HotelManagementDb;Integrated Security=True
        public HMSDbContext()
            : base(@"Data Source=PATRIKDATA\SQLEXPRESS;Initial Catalog=HotelManagementDb;Integrated Security=True")
        {
        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }   
        public DbSet<RoomCategory> RoomCategory { get; set; }
        public DbSet<RoomCapacity> RoomCapacity { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}