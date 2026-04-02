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
		public EFCarDal(CarolaContext context) : base(context)
		{
		}

		public async Task<List<Car>> GetAllCarsWithCategoryAsync()
		{
			var context= new CarolaContext();
			var values=await context.Cars.Include(x=>x.Category).ToListAsync();
			return values;
		}
	}
}
