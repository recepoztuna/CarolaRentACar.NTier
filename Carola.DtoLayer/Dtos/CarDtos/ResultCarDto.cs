using Carola.DtoLayer.Dtos.CarImageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DtoLayer.Dtos.CarDtos
{
	public class ResultCarDto
	{
		public int CarId { get; set; }
		public string Model { get; set; }
		public int ModelYear { get; set; }
		public decimal DailyPrice { get; set; }
		public bool IsAvailable { get; set; }
		public string FuelType { get; set; }
		public string TransmissionType { get; set; }
		public string ImageUrl { get; set; }

		public int LocationId { get; set; }
		public string LocationName { get; set; } 
		public string City { get; set; }
		public string BrandName { get; set; }
		public string CategoryName { get; set; }
		public int SeatCount { get; set; }     
		public int Mileage { get; set; }

		public List<ResultCarImageDto> CarImages { get; set; }
	}
}
