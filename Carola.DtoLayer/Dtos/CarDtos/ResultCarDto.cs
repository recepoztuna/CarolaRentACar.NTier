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

		// İlişkili veriler - flatten ettik
		public string BrandName { get; set; }
		public string CategoryName { get; set; }

		public List<ResultCarImageDto> CarImages { get; set; }
	}
}
