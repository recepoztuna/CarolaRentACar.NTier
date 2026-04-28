using Carola.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarSliderComponentPartial:ViewComponent
	{
		private readonly ISliderService _sliderService;

		public _CarSliderComponentPartial(ISliderService sliderService)
		{
			_sliderService = sliderService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _sliderService.GetAllSliderAsync();
			return View(values);
		}
		
	}
}
