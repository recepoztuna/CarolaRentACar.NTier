using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.EntityLayer.Entities
{
	public class InsuranceCompany
	{
		public int InsuranceCompanyId { get; set; }
		public string CompanyName { get; set; }
		public string LogoUrl { get; set; }
		public bool IsActive { get; set; }
	}
}
