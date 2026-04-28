using Carola.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarCategoryComponentPartial:ViewComponent
	{
		private readonly ICategoryService _categoryService;

		public _CarCategoryComponentPartial(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public async Task<IViewComponentResult> InvokeAsync() 
		{  
			var value=await _categoryService.GetAllCategoryAsync();
			return View(value); 
		}
	}
}
