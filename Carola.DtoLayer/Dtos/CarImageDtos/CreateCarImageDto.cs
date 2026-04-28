using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DtoLayer.Dtos.CarImageDtos
{
	public class CreateCarImageDto
	{
	
		public string ImageUrl { get; set; }
		public bool IsCoverImage { get; set; }
		public int CarId { get; set; }
	}
}
