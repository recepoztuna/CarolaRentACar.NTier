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
	public class EFCarDal : GenericRepository<Car>, ICarDal
	{
		private readonly CarolaContext _context;
		public EFCarDal(CarolaContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<Car>> GetAllCarsWithCategoryAsync()
		{
			var context= new CarolaContext();
			var values=await context.Cars.Include(x=>x.Category).ToListAsync();
			return values;
		}
		public async Task<List<Car>> GetLast6CarsAsync()
		{
			return await _context.Cars
		.Include(x => x.Brand)
		.Include(x => x.Category)
		.Include(x => x.Location) 
		.Where(x => x.IsAvailable)
		.OrderByDescending(x => x.CarId)
		.Take(6)
		.ToListAsync();
		}
	}
}
