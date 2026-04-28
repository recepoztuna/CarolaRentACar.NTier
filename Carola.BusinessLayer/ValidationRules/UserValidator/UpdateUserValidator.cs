using Carola.DtoLayer.Dtos.UserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.ValidationRules.UserValidator
{
	public class UpdateUserValidator:AbstractValidator<UpdateUserDto>
	{
		public UpdateUserValidator()
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

			RuleFor(x => x.Role)
				.IsInEnum().WithMessage("Geçerli bir rol seçiniz");
		}
	}
}
