using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.EntityLayer.Entities
{
	public class CarImage
	{
		public int CarImageId { get; set; }
		public string ImageUrl { get; set; }
		public bool IsCoverImage { get; set; }
		public int CarId { get; set; }
		public Car Car { get; set; }
	}
}
