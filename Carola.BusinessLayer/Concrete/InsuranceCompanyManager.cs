using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Concrete;
using Carola.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class InsuranceCompanyManager:IInsuranceCompanyService
	{
		private readonly CarolaContext _context;

		public InsuranceCompanyManager(CarolaContext context)
		{
			_context = context;
		}

		public async Task<List<InsuranceCompany>> GetAllInsuranceCompanyAsync()
		{
			return await _context.InsuranceCompanies
				.Where(x => x.IsActive).ToListAsync();
				
		}

		public async Task<InsuranceCompany> GetByIdInsuranceCompanyAsync(int id)
		{
			return await _context.InsuranceCompanies.FindAsync(id);
		}

		public async Task CreateInsuranceCompanyAsync(InsuranceCompany insuranceCompany)
		{
			await _context.InsuranceCompanies.AddAsync(insuranceCompany);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateInsuranceCompanyAsync(InsuranceCompany insuranceCompany)
		{
			_context.InsuranceCompanies.Update(insuranceCompany);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteInsuranceCompanyAsync(int id)
		{
			var entity = await _context.InsuranceCompanies.FindAsync(id);
			if (entity != null)
			{
				_context.InsuranceCompanies.Remove(entity);
				await _context.SaveChangesAsync();
			}
		}
	}
}
