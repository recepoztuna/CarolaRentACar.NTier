using Carola.BusinessLayer.Abstract;
using Carola.EntityLayer.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Carola.WebUI.Controllers
{
	public class TestBrandController : Controller
	{
		private readonly IBrandService _brandService;

		public TestBrandController(IBrandService brandService)
		{
			_brandService = brandService;
		}

		public IActionResult CreatBrand()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateBrand(Brand brand)
		{
			if (!ModelState.IsValid)
				return View(brand); // Hataları view'a geri döndür

			try
			{
				await _brandService.TInsertAsync(brand);
				return RedirectToAction("Index");
			}
			catch (ValidationException ex)
			{
				foreach (var error in ex.Errors)
					ModelState.AddModelError(error.PropertyName, error.ErrorMessage);


				return View(brand);

			}
		}
	}
}
