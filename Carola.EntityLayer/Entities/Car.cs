using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.EntityLayer.Entities
{
	public class Car
	{
		public int CarId { get; set; }
		
		public string Model { get; set; }
		public int ModelYear { get; set; }
		public string PlateNumber { get; set; }
		public decimal DailyPrice { get; set; }
		public int SeatCount { get; set; }        // Kişi sayısı
		public int LuggageCapacity { get; set; }  // Bagaj kapasitesi
		public int Mileage { get; set; }
		public bool IsAvailable { get; set; }
		public string FuelType { get; set; }
		public string TransmissionType { get; set; }
		public int CategoryId { get; set; }
		
		public string ImageUrl { get; set; }

		public int BrandId { get; set; }      
		public Brand Brand { get; set; }
		public Category Category { get; set; }
		public ICollection<Reservation> Reservations { get; set; }
		public ICollection<CarImage> CarImages { get; set; }




	}
}
