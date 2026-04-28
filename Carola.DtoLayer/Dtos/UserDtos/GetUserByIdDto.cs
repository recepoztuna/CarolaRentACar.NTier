using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.DtoLayer.Dtos.UserDtos
{
	public class GetUserByIdDto
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public int Role { get; set; }

		// Flatten
		public string LocationName { get; set; }
		public string LocationCity { get; set; }
		// PasswordHash kesinlikle yok!
	}
}
