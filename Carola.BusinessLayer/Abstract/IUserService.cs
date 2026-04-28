using Carola.DtoLayer.Dtos.UserDtos;
using Carola.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Abstract
{
	public interface IUserService
	{
		Task<List<ResultUserDto>> GetAllUserAsync();
		Task<GetUserByIdDto> GetUserByIdAsync(int id);
		Task CreateUserAsync(CreateUserDto createUserDto);
		Task UpdateUserAsync(UpdateUserDto updateUserDto);
		Task DeleteUserAsync(int id);

	}
}
