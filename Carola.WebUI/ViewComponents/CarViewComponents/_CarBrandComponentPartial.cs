using Carola.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarBrandComponentPartial:ViewComponent
	{
		private readonly IBrandService _brandService;

		public _CarBrandComponentPartial(IBrandService brandService)
		{
			_brandService = brandService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values= await _brandService.GetAllBrandAsync();
			return View(values);
		}
	}
}
