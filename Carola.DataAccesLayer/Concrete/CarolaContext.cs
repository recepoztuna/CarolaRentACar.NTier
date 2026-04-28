using Carola.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DataAccesLayer.Concrete
{
	public class CarolaContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data source =DESKTOP-BAO5HTQ; Initial catalog =CarolaRentDb;Integrated security=true;TrustServerCertificate=true");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Reservation → PickupLocation
			modelBuilder.Entity<Reservation>()
				.HasOne(r => r.PickupLocation)
				.WithMany()
				.HasForeignKey(r => r.PickupLocationId)
				.OnDelete(DeleteBehavior.Restrict);

			// Reservation → ReturnLocation
			modelBuilder.Entity<Reservation>()
				.HasOne(r => r.ReturnLocation)
				.WithMany()
				.HasForeignKey(r => r.ReturnLocationId)
				.OnDelete(DeleteBehavior.Restrict);

			// Location → User (1'e 1)
			modelBuilder.Entity<Location>()
				.HasOne(l => l.AuthorizedPerson)
				.WithOne(u => u.Location)
				.HasForeignKey<Location>(l => l.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			// Car → Brand
			modelBuilder.Entity<Car>()
				.HasOne(c => c.Brand)
				.WithMany(b => b.Cars)
				.HasForeignKey(c => c.BrandId)
				.OnDelete(DeleteBehavior.Restrict);

			// Reservation → Car
			modelBuilder.Entity<Reservation>()
				.HasOne(r => r.Car)
				.WithMany(c => c.Reservations)
				.HasForeignKey(r => r.CarId)
				.OnDelete(DeleteBehavior.Restrict);

			// Reservation → Customer
			modelBuilder.Entity<Reservation>()
				.HasOne(r => r.Customer)
				.WithMany(c => c.Reservations)
				.HasForeignKey(r => r.CustomerId)
				.OnDelete(DeleteBehavior.Restrict);

		}
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Car>Cars { get; set; }
		public DbSet<User>Users { get; set; }
		public DbSet<Category>Categories { get; set; }
		public DbSet<Customer>Customers { get; set; }
		public DbSet<Location>Locations { get; set; }
		public DbSet<Reservation>Reservations { get; set; }
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<CarImage> CarImages { get; set; }

	}
}
