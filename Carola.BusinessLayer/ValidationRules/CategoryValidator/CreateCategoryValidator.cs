using Carola.DtoLayer.Dtos.CategoryDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carola.BusinessLayer.ValidationRules.CategoryValidator
{
	public class CreateCategoryValidator:AbstractValidator<CreateCategoryDto>

	{
		public CreateCategoryValidator()
		{
			RuleFor(x => x.CategoryName)
			.NotEmpty().WithMessage("Kategori adı boş olamaz")
			.MinimumLength(2).WithMessage("Kategori adı en az 2 karakter olmalıdır")
			.MaximumLength(50).WithMessage("Kategori adı en fazla 50 karakter olabilir");
		}
	}
}
