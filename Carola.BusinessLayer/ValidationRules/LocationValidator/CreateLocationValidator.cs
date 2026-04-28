using Carola.DtoLayer.Dtos.LocationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.ValidationRules.LocationValidator
{
	public class CreateLocationValidator :AbstractValidator<CreateLocationDto>
	{
		public CreateLocationValidator()
		{
			RuleFor(x => x.LocationName)
			.NotEmpty().WithMessage("Lokasyon adı boş olamaz")
			.MinimumLength(2).WithMessage("Lokasyon adı en az 2 karakter olmalıdır")
			.MaximumLength(100).WithMessage("Lokasyon adı en fazla 100 karakter olabilir");

			RuleFor(x => x.City)
				.NotEmpty().WithMessage("Şehir boş olamaz")
				.MinimumLength(2).WithMessage("Şehir en az 2 karakter olmalıdır");

			RuleFor(x => x.Address)
				.NotEmpty().WithMessage("Adres boş olamaz")
				.MinimumLength(5).WithMessage("Adres en az 5 karakter olmalıdır");

			RuleFor(x => x.UserId)
				.GreaterThan(0).WithMessage("Yetkili kişi seçiniz");
		}
	}
}
