using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.EntityLayer.Entities
{
	public class Brand
	{
		public int BrandId { get; set; }
		public string BrandName { get; set; }          // BMW, Mercedes, Toyota
		    
		public string LogoUrl { get; set; }            // Marka logosu
		public bool Status { get; set; }               // Aktif / Pasif

		public ICollection<Car> Cars { get; set; }


	}
}
