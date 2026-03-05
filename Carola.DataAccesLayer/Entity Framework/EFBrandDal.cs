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
	public class EFBrandDal : GenericRepository<Brand>, IBrandDal
	{
		public EFBrandDal(CarolaContext context) : base(context)
		{
		}
	}
}
