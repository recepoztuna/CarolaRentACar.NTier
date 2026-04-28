using Carola.DtoLayer.Dtos.CarDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.ValidationRules.CarValidator
{
	public class UpdateCarValidator :AbstractValidator<UpdateCarDto>
	{
		public UpdateCarValidator()
		{


			RuleFor(x => x.Model)
				.NotEmpty().WithMessage("Model boş olamaz")
				.MinimumLength(2).WithMessage("Model en az 2 karakter olmalıdır");

			RuleFor(x => x.ModelYear)
				.GreaterThan(1900).WithMessage("Geçerli bir yıl giriniz")
				.LessThanOrEqualTo(DateTime.Now.Year).WithMessage("Geçerli bir yıl giriniz");

			RuleFor(x => x.PlateNumber)
				.NotEmpty().WithMessage("Plaka boş olamaz");

			RuleFor(x => x.DailyPrice)
				.GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır");

			RuleFor(x => x.SeatCount)
				.GreaterThan(0).WithMessage("Koltuk sayısı 0'dan büyük olmalıdır");

			RuleFor(x => x.LuggageCapacity)
				.GreaterThan(0).WithMessage("Bagaj kapasitesi 0'dan büyük olmalıdır");

			RuleFor(x => x.FuelType)
				.NotEmpty().WithMessage("Yakıt tipi boş olamaz");

			RuleFor(x => x.TransmissionType)
				.NotEmpty().WithMessage("Vites tipi boş olamaz");

			RuleFor(x => x.BrandId)
				.GreaterThan(0).WithMessage("Marka seçiniz");

			RuleFor(x => x.CategoryId)
				.GreaterThan(0).WithMessage("Kategori seçiniz");
		}
	}
}
