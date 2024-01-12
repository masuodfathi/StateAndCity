using StateAndCity.Interfaces;
using StateAndCity.Models;

namespace StateAndCity.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public CityModel GetCityById(int id)
        {
            return _cityRepository.GetCityById(id);
        }

        public ICollection<CityModel> GetCities()
        {
            return _cityRepository.GetCities();
        }
        public string GetCityImagePath(int cityId)
        {
            return _cityRepository.GetCityImageUrl(cityId);
        }

        public CityModel GetCityByName(string name)
        {
            return _cityRepository.GetCityByName(name);
        }

        public bool CreateCity(CityModel city)
        {
            return _cityRepository.CreateCity(city);
        }

        public bool UpdateCity(CityModel city)
        {
            return _cityRepository.UpdateCity(city);
        }

        public bool DeleteCity(int id)
        {
            return _cityRepository.DeleteCity(id);
        }

        public bool SaveCityImagePath(int cityId, string imagePath)
        {
            throw new NotImplementedException();
        }
    }
}
