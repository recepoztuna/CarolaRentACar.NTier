using Carola.DtoLayer.Dtos.ReservationDtos;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.ValidationRules.ReservationValidator
{
	public class UpdateReservationValidator:AbstractValidator<UpdateReservationDto>
	{
		public UpdateReservationValidator()
		{
			RuleFor(x => x.CarId)
			.GreaterThan(0).WithMessage("Araç seçiniz");

			RuleFor(x => x.CustomerId)
				.GreaterThan(0).WithMessage("Müşteri seçiniz");

			RuleFor(x => x.PickupDate)
				.NotEmpty().WithMessage("Alış tarihi boş olamaz");

			RuleFor(x => x.ReturnDate)
				.NotEmpty().WithMessage("Dönüş tarihi boş olamaz")
				.GreaterThan(x => x.PickupDate).WithMessage("Dönüş tarihi alış tarihinden büyük olmalıdır");

			RuleFor(x => x.PickupLocationId)
				.GreaterThan(0).WithMessage("Alış lokasyonu seçiniz");

			RuleFor(x => x.ReturnLocationId)
				.GreaterThan(0).WithMessage("Dönüş lokasyonu seçiniz");

			RuleFor(x => x.TotalPrice)
				.GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır");
		}
	}
}
