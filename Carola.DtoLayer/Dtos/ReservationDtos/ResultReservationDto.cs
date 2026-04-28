using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DtoLayer.Dtos.ReservationDtos
{
	public class ResultReservationDto
	{
		public int ReservationId { get; set; }
		public DateTime PickupDate { get; set; }
		public DateTime ReturnDate { get; set; }
		public decimal TotalPrice { get; set; }
		public int ReservationStatus { get; set; }

		// Car - flatten
		public string CarModel { get; set; }
		public string CarBrandName { get; set; }

		// Customer - flatten
		public string CustomerFirstName { get; set; }
		public string CustomerLastName { get; set; }

		// Location - flatten
		public string PickupLocationName { get; set; }
		public string ReturnLocationName { get; set; }
	}
}
