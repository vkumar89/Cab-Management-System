using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CabManagment.Models
{
    public class CabDbContext:DbContext
    {
        public CabDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CabDbContext>());
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Drivers> drivers { get; set; }
        public DbSet<Admins> admins { get; set; }
        public DbSet<Vehicles> vehicles { get; set; }
        public DbSet<Booking_Requests> booking_Requests { get; set; }
        public DbSet<Routes> routes { get; set; }
        public DbSet<Payment_Gateway> payment_Gateways { get; set; }
        public DbSet<Customer_Support> customer_Supports { get; set; }
        public DbSet<GPS_Location_Tracking> gPS_Location_Trackings { get; set; }


    }
}