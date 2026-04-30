using Carola.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.ViewComponents.CarViewComponents
{
	public class _CarInsuranceCompanyComponentPartial:ViewComponent
	{
		private readonly IInsuranceCompanyService _insuranceCompanyService;

		public _CarInsuranceCompanyComponentPartial(IInsuranceCompanyService insuranceCompanyService)
		{
			_insuranceCompanyService = insuranceCompanyService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values= await _insuranceCompanyService.GetAllInsuranceCompanyAsync();
			return View(values);
		}
	}
}
