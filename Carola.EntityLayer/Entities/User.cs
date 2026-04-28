using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.EntityLayer.Entities
{
	public class User
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PasswordHash { get; set; }
		public int Role { get; set; } // 0 = Admin, 1 = LocationManager
		public Location Location { get; set; }
	}
}
