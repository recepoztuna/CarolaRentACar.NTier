using Carola.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarSearchBarComponentPartial:ViewComponent
	{
		private readonly ILocationService _locationService;

		public _CarSearchBarComponentPartial(ILocationService locationService)
		{
			_locationService = locationService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values= await _locationService.GetAllLocationAsync();
			return View(values);
		}
	}
}
