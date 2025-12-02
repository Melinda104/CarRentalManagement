using CarRentalManagement.Domain;
using CarRentalManagement.Configurations.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext : DbContext
    {
        public CarRentalManagementContext(DbContextOptions<CarRentalManagementContext> options) : base(options)
        {
        }

        public DbSet<CarRentalManagement.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}