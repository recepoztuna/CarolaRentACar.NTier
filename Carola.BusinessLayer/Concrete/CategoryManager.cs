using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DtoLayer.Dtos.CategoryDtos;
using Carola.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;
		private readonly IMapper _mapper;
		private readonly IValidator<CreateCategoryDto> _createValidator;
		private readonly IValidator<UpdateCategoryDto> _updateValidator;

		public CategoryManager(ICategoryDal categoryDal, IMapper mapper,
			IValidator<CreateCategoryDto> createValidator,
			IValidator<UpdateCategoryDto> updateValidator)
		{
			_categoryDal = categoryDal;
			_mapper = mapper;
			_createValidator = createValidator;
			_updateValidator = updateValidator;
		}

		public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
		{
			var validationResult = await _createValidator.ValidateAsync(createCategoryDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Category>(createCategoryDto);
			await _categoryDal.InsertAsync(value);
		}

		public async Task DeleteCategoryAsync(int id)
		{
			await _categoryDal.DeleteAsync(id);
		}

		public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
		{
			var values = await _categoryDal.GetAllAsync();
			return _mapper.Map<List<ResultCategoryDto>>(values);
		}

		public async Task<GetCategoryByIdDto> GetCategoryByIdAsync(int id)
		{
			var value = await _categoryDal.GetByIdAsync(id);
			return _mapper.Map<GetCategoryByIdDto>(value);
		}

		public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
		{
			var validationResult = await _updateValidator.ValidateAsync(updateCategoryDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Category>(updateCategoryDto);
			await _categoryDal.UpdateAsync(value);
		}
	}
}
