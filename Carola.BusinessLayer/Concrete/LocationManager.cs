using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DtoLayer.Dtos.LocationDtos;
using Carola.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class LocationManager : ILocationService
	{
		private readonly ILocationDal _locationDal;
		private readonly IMapper _mapper;
		private readonly IValidator<CreateLocationDto> _createValidator;
		private readonly IValidator<UpdateLocationDto> _updateValidator;

		public LocationManager(ILocationDal locationDal, IMapper mapper,
			IValidator<CreateLocationDto> createValidator,
			IValidator<UpdateLocationDto> updateValidator)
		{
			_locationDal = locationDal;
			_mapper = mapper;
			_createValidator = createValidator;
			_updateValidator = updateValidator;
		}

		public async Task CreateLocationAsync(CreateLocationDto createLocationDto)
		{
			var validationResult = await _createValidator.ValidateAsync(createLocationDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Location>(createLocationDto);
			await _locationDal.InsertAsync(value);
		}

		public async Task DeleteLocationAsync(int id)
		{
			await _locationDal.DeleteAsync(id);
		}

		public async Task<List<ResultLocationDto>> GetAllLocationAsync()
		{
			var values = await _locationDal.GetAllAsync();
			return _mapper.Map<List<ResultLocationDto>>(values);
		}

		public async Task<GetLocationByIdDto> GetLocationByIdAsync(int id)
		{
			var value = await _locationDal.GetByIdAsync(id);
			return _mapper.Map<GetLocationByIdDto>(value);
		}

		public async Task UpdateLocationAsync(UpdateLocationDto updateLocationDto)
		{
			var validationResult = await _updateValidator.ValidateAsync(updateLocationDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Location>(updateLocationDto);
			await _locationDal.UpdateAsync(value);
		}
	}
}
