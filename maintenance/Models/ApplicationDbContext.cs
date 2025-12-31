using Microsoft.EntityFrameworkCore;

namespace maintenance.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
               new Customer
               {
                   Id = 1,
                   Name = "Test Customer",
                   Phone = "0100000000",
                   Address = "Cairo"
               }
            );

            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    Id = 1,
                    Name = "Air Conditioner",
                    Model = "LG-2023",
                    SerialNumber = "AC-001",


                },
                 new Equipment
                 {
                     Id = 2,
                     Name = "Washing Machine",
                     Model = "Samsung-X",
                     SerialNumber = "WM-777"
                 }
                   );
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Assignment> Assignments { get; set; }


        public DbSet<User> Users { get; set; }







    }


}
