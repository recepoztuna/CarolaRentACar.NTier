using Carola.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Abstract
{
	public interface IInsuranceCompanyService
	{
		Task<List<InsuranceCompany>> GetAllInsuranceCompanyAsync();
		Task<InsuranceCompany> GetByIdInsuranceCompanyAsync(int id);
		Task CreateInsuranceCompanyAsync(InsuranceCompany insuranceCompany);
		Task UpdateInsuranceCompanyAsync(InsuranceCompany insuranceCompany);
		Task DeleteInsuranceCompanyAsync(int id);
	}
}
