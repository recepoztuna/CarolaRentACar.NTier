using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DtoLayer.Dtos.CategoryDtos
{
	public class GetCategoryByIdDto
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
	}
}
