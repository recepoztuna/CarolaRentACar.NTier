using Carola.BusinessLayer.Abstract;
using Carola.DtoLayer.Dtos.LocationDtos;
using Carola.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Carola.WebUI.Controllers
{
	public class LocationController : Controller
	{
		private readonly ILocationService _locationService;

		public LocationController(ILocationService locationService)
		{
			_locationService = locationService;
		}

		public async  Task<IActionResult> LocationList()
		{
			var values=await _locationService.GetAllLocationAsync();

			return View(values);
		}
		public IActionResult CreateLocation()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateLocation(CreateLocationDto createLocationDto)
		{
			await _locationService.CreateLocationAsync(createLocationDto);

			return RedirectToAction(" LocationList");
		}
		public async Task<IActionResult> DeleteLocation(int id)
		{
			await _locationService.DeleteLocationAsync(id);
			return RedirectToAction("LocationList");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateLocation(int id)
		{
			var values=await _locationService.GetLocationByIdAsync(id);
			return View(values);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateLocation(UpdateLocationDto updateLocationDto)
		{
			await _locationService.UpdateLocationAsync(updateLocationDto);
			return RedirectToAction("LocationList");
		}

	}
}
