using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DtoLayer.Dtos.BrandDtos
{
	public class UpdateBrandDto
	{
		public int BrandId { get; set; }
		public string BrandName { get; set; }          // BMW, Mercedes, Toyota

		public string LogoUrl { get; set; }            // Marka logosu
		public bool Status { get; set; }
	}
}
