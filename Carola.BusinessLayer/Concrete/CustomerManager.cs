using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DtoLayer.Dtos.CustomerDtos;
using Carola.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class CustomerManager : ICustomerService
	{
		private readonly ICustomerDal _customerDal;
		private readonly IMapper _mapper;
		private readonly IValidator<CreateCustomerDto> _createValidator;
		private readonly IValidator<UpdateCustomerDto> _updateValidator;

		public CustomerManager(ICustomerDal customerDal, IMapper mapper,
			IValidator<CreateCustomerDto> createValidator,
			IValidator<UpdateCustomerDto> updateValidator)
		{
			_customerDal = customerDal;
			_mapper = mapper;
			_createValidator = createValidator;
			_updateValidator = updateValidator;
		}

		public async Task CreateCustomerAsync(CreateCustomerDto createCustomerDto)
		{
			var validationResult = await _createValidator.ValidateAsync(createCustomerDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Customer>(createCustomerDto);
			await _customerDal.InsertAsync(value);
		}

		public async Task DeleteCustomerAsync(int id)
		{
			await _customerDal.DeleteAsync(id);
		}

		public async Task<List<ResultCustomerDto>> GetAllCustomerAsync()
		{
			var values = await _customerDal.GetAllAsync();
			return _mapper.Map<List<ResultCustomerDto>>(values);
		}

		public async Task<GetCustomerByIdDto> GetCustomerByIdAsync(int id)
		{
			var value = await _customerDal.GetByIdAsync(id);
			return _mapper.Map<GetCustomerByIdDto>(value);
		}

		public async Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto)
		{
			var validationResult = await _updateValidator.ValidateAsync(updateCustomerDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Customer>(updateCustomerDto);
			await _customerDal.UpdateAsync(value);
		}
	}
}
