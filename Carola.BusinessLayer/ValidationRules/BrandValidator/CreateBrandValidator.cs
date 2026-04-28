using Carola.DtoLayer.Dtos.BrandDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.ValidationRules.BrandValidator
{
	public class CreateBrandValidator :AbstractValidator<CreateBrandDto>
	{
		public CreateBrandValidator()
		{
			RuleFor(x => x.BrandName)
			.NotEmpty().WithMessage("Marka adı boş olamaz")
			.MinimumLength(2).WithMessage("Marka adı en az 2 karakter olmalıdır")
			.MaximumLength(50).WithMessage("Marka adı en fazla 50 karakter olabilir");

			RuleFor(x => x.LogoUrl)
				.NotEmpty().WithMessage("Logo URL boş olamaz");

			RuleFor(x => x.Status)
				.NotNull().WithMessage("Durum boş olamaz");
		}
	}
}
