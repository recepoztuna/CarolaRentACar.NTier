using Carola.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarLastImageComponentPartial:ViewComponent
	{
		private readonly ICarService _carService;

		public _CarLastImageComponentPartial(ICarService carService)
		{
			_carService = carService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _carService.GetLast6CarsAsync();
			return View(values);
		}
	}
}
