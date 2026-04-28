using Carola.DtoLayer.Dtos.CustomerDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.ValidationRules.CustomerValidator
{
	public class CreateCustomerValidator:AbstractValidator<CreateCustomerDto>
	{
		public CreateCustomerValidator()
		{
			RuleFor(x => x.FirstName)
			.NotEmpty().WithMessage("Ad boş olamaz")
			.MinimumLength(2).WithMessage("Ad en az 2 karakter olmalıdır")
			.MaximumLength(50).WithMessage("Ad en fazla 50 karakter olabilir");

			RuleFor(x => x.LastName)
				.NotEmpty().WithMessage("Soyad boş olamaz")
				.MinimumLength(2).WithMessage("Soyad en az 2 karakter olmalıdır")
				.MaximumLength(50).WithMessage("Soyad en fazla 50 karakter olabilir");

			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("Email boş olamaz")
				.EmailAddress().WithMessage("Geçerli bir email giriniz");

			RuleFor(x => x.Phone)
				.NotEmpty().WithMessage("Telefon boş olamaz")
				.MinimumLength(10).WithMessage("Geçerli bir telefon numarası giriniz");

			RuleFor(x => x.DriverLicenseNumber)
				.NotEmpty().WithMessage("Ehliyet numarası boş olamaz");

			RuleFor(x => x.BirthDate)
				.NotEmpty().WithMessage("Doğum tarihi boş olamaz")
				.LessThan(DateTime.Now.AddYears(-18)).WithMessage("18 yaşından küçük olamaz");
		}
	}
}
