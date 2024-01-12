using Microsoft.AspNetCore.Mvc;
using StateAndCity.Interfaces;
using StateAndCity.Models;
using StateAndCity.ViewModels;

namespace StateAndCity.Controllers
{
    public class SelectLocationController : Controller
    {
        private readonly IStateService _stateService;
        private readonly ICityService _cityService;
        public SelectLocationController(IStateService stateService, ICityService cityService)
        {
            _stateService = stateService;
            _cityService = cityService;
        }
        public IActionResult Index()
        {
            var viewModel = new CityViewModel
            {
                States = _stateService.GetStates().ToList(),
                Cities = new List<CityModel>()
            };
            return View(viewModel);
        }
        [HttpGet]
        public JsonResult GetCitiesByState(int stateId)
        {
            var cities = _stateService.GetCitiesByState(stateId);
            return Json(cities);
        }
        [HttpGet]
        public JsonResult GetCityImage(int cityId)
        {
            var cityImagePath = _cityService.GetCityImagePath(cityId);
            return Json(cityImagePath);
        }
    }
}
