using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DtoLayer.Dtos.ReservationDtos
{
	public class GetReservationByIdDto
	{
		public int ReservationId { get; set; }
		public DateTime PickupDate { get; set; }
		public DateTime ReturnDate { get; set; }
		public decimal TotalPrice { get; set; }
		public int ReservationStatus { get; set; }
		public string Description { get; set; }

		// Car - flatten
		public string CarModel { get; set; }
		public string CarPlateNumber { get; set; }
		public string CarBrandName { get; set; }
		public string CarImageUrl { get; set; }

		// Customer - flatten
		public string CustomerFirstName { get; set; }
		public string CustomerLastName { get; set; }
		public string CustomerEmail { get; set; }
		public string CustomerPhone { get; set; }

		// Location - flatten
		public string PickupLocationName { get; set; }
		public string PickupLocationCity { get; set; }
		public string ReturnLocationName { get; set; }
		public string ReturnLocationCity { get; set; }
	}
}
