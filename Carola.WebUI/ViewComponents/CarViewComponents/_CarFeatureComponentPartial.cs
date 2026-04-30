using Carola.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarFeatureComponentPartial:ViewComponent
	{
		private readonly IFeatureService _featureService;

		public _CarFeatureComponentPartial(IFeatureService featureService)
		{
			_featureService = featureService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values= await _featureService.GetAllFeatureAsync();
			return View(values);
		}
	}
}
