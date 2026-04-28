using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DtoLayer.Dtos.BrandDtos;
using Carola.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class BrandManager : IBrandService
	{
		private readonly IBrandDal _brandDal;
		private readonly IMapper _mapper;
		private readonly IValidator<CreateBrandDto> _createValidator;
		private readonly IValidator<UpdateBrandDto> _updateValidator;

		public BrandManager(IBrandDal brandDal, IMapper mapper,
			IValidator<CreateBrandDto> createValidator,
			IValidator<UpdateBrandDto> updateValidator)
		{
			_brandDal = brandDal;
			_mapper = mapper;
			_createValidator = createValidator;
			_updateValidator = updateValidator;
		}

		public async Task CreateBrandAsync(CreateBrandDto createBrandDto)
		{
			var validationResult = await _createValidator.ValidateAsync(createBrandDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Brand>(createBrandDto);
			await _brandDal.InsertAsync(value);
		}

		public async Task DeleteBrandAsync(int id)
		{
			await _brandDal.DeleteAsync(id);
		}

		public async Task<List<ResultBrandDto>> GetAllBrandAsync()
		{
			var values = await _brandDal.GetAllAsync();
			return _mapper.Map<List<ResultBrandDto>>(values);
		}

		public async Task<GetBrandByIdDto> GetBrandByIdAsync(int id)
		{
			var value = await _brandDal.GetByIdAsync(id);
			return _mapper.Map<GetBrandByIdDto>(value);
		}

		public async Task UpdateBrandAsync(UpdateBrandDto updateBrandDto)
		{
			var validationResult = await _updateValidator.ValidateAsync(updateBrandDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Brand>(updateBrandDto);
			await _brandDal.UpdateAsync(value);
		}
	}
}
