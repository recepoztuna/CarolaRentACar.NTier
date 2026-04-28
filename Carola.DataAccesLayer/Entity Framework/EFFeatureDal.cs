using Carola.DataAccesLayer.Abstract;
using Carola.DataAccesLayer.Concrete;
using Carola.DataAccesLayer.Repository;
using Carola.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DataAccesLayer.Entity_Framework
{
	public class EFFeatureDal:GenericRepository<Feature>,IFeatureDal
	{
		public EFFeatureDal(CarolaContext context):base(context) 
		{
			
		}
	}
}
