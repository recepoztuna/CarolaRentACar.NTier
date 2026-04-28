using AutoMapper;
using Carola.BusinessLayer.Abstract;
using Carola.DataAccesLayer.Abstract;
using Carola.DtoLayer.Dtos.ReservationDtos;
using Carola.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.Concrete
{
	public class ReservationManager : IReservationService
	{
		private readonly IReservationDal _reservationDal;
		private readonly IMapper _mapper;
		private readonly IValidator<CreateReservationDto> _createValidator;
		private readonly IValidator<UpdateReservationDto> _updateValidator;

		public ReservationManager(IReservationDal reservationDal, IMapper mapper,
			IValidator<CreateReservationDto> createValidator,
			IValidator<UpdateReservationDto> updateValidator)
		{
			_reservationDal = reservationDal;
			_mapper = mapper;
			_createValidator = createValidator;
			_updateValidator = updateValidator;
		}

		public async Task CreateReservationAsync(CreateReservationDto createReservationDto)
		{
			var validationResult = await _createValidator.ValidateAsync(createReservationDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Reservation>(createReservationDto);
			await _reservationDal.InsertAsync(value);
		}

		public async Task DeleteReservationAsync(int id)
		{
			await _reservationDal.DeleteAsync(id);
		}

		public async Task<List<ResultReservationDto>> GetAllReservationAsync()
		{
			var values = await _reservationDal.GetAllAsync();
			return _mapper.Map<List<ResultReservationDto>>(values);
		}

		public async Task<GetReservationByIdDto> GetReservationByIdAsync(int id)
		{
			var value = await _reservationDal.GetByIdAsync(id);
			return _mapper.Map<GetReservationByIdDto>(value);
		}

		public async Task UpdateReservationAsync(UpdateReservationDto updateReservationDto)
		{
			var validationResult = await _updateValidator.ValidateAsync(updateReservationDto);
			if (!validationResult.IsValid)
				throw new ValidationException(validationResult.Errors);

			var value = _mapper.Map<Reservation>(updateReservationDto);
			await _reservationDal.UpdateAsync(value);
		}
	}
}
