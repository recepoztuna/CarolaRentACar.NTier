using Carola.BusinessLayer.Abstract;
using Carola.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BrandController : Controller
	{
		private readonly IBrandService _brandService;

		public BrandController(IBrandService brandService)
		{
			_brandService = brandService;
		}

		public async Task<IActionResult> BrandList()
		{
			var values= await _brandService.TGetAllAsync();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateBrand()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateBrand(Brand brand)
		{
			await _brandService.TInsertAsync(brand);
			return RedirectToAction("BrandList");
		}
		[HttpGet]
		public async Task<IActionResult> UpdateBrand(int id)
		{
			var values=await _brandService.TGetByIdAsync(id);
			return View(values);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateBrand(Brand brand)
		{
			await _brandService.TUpdateAsync(brand);
			return RedirectToAction("BrandList");
		}
		public async Task<IActionResult> Delete(int id)
		{
			await _brandService.TDeleteAsync(id);
			return RedirectToAction("BrandList");
		}
	}
}
