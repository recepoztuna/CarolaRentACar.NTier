using Carola.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DataAccesLayer.Abstract
{
	public interface ICarDal: IGenericDal<Car>
	{
		Task<List<Car>> GetAllCarsWithCategoryAsync();
		Task<List<Car>> GetLast6CarsAsync();
	}
}
