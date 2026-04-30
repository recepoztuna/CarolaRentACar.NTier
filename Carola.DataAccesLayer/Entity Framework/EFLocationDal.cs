using Carola.DataAccesLayer.Abstract;
using Carola.DataAccesLayer.Concrete;
using Carola.DataAccesLayer.Repository;
using Carola.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DataAccesLayer.Entity_Framework
{
	public class EFLocationDal : GenericRepository<Location>, ILocationDal
	{
		private readonly CarolaContext _context;

		public EFLocationDal(CarolaContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<Location>> GetAllWithPersonAsync()
		{
			return await _context.Locations
				.Include(x => x.AuthorizedPerson)
				.ToListAsync();
		}
	}
}
