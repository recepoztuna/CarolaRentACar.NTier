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
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Car>Cars { get; set; }
		public DbSet<Category>Categories { get; set; }
		public DbSet<Customer>Customers { get; set; }
		public DbSet<Location>Locations { get; set; }
		public DbSet<Reservation>Reservations { get; set; }
	}
}
