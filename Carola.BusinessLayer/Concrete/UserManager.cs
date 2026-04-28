using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DtoLayer.Dtos.UserDtos;
using Carola.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class UserManager : IUserService
	{
		private readonly IUserDal _userDal;
		private readonly IMapper _mapper;
		private readonly IValidator<CreateUserDto> _createValidator;
		private readonly IValidator<UpdateUserDto> _updateValidator;

		public UserManager(IUserDal userDal, IMapper mapper,
			IValidator<CreateUserDto> createValidator,
			IValidator<UpdateUserDto> updateValidator)
		{
			_userDal = userDal;
			_mapper = mapper;
			_createValidator = createValidator;
			_updateValidator = updateValidator;
		}

		public async Task CreateUserAsync(CreateUserDto createUserDto)
		{
			var validationResult = await _createValidator.ValidateAsync(createUserDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<User>(createUserDto);
			await _userDal.InsertAsync(value);
		}

		public async Task DeleteUserAsync(int id)
		{
			await _userDal.DeleteAsync(id);
		}

		public async Task<List<ResultUserDto>> GetAllUserAsync()
		{
			var values = await _userDal.GetAllAsync();
			return _mapper.Map<List<ResultUserDto>>(values);
		}

		public async Task<GetUserByIdDto> GetUserByIdAsync(int id)
		{
			var value = await _userDal.GetByIdAsync(id);
			return _mapper.Map<GetUserByIdDto>(value);
		}

		public async Task UpdateUserAsync(UpdateUserDto updateUserDto)
		{
			var validationResult = await _updateValidator.ValidateAsync(updateUserDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<User>(updateUserDto);
			await _userDal.UpdateAsync(value);
		}
	}
}
