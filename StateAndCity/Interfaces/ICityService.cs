using StateAndCity.Models;

namespace StateAndCity.Interfaces
{
    public interface ICityService
    {
        ICollection<CityModel> GetCities();
        CityModel GetCityById(int id);
        CityModel GetCityByName(string name);
        bool CreateCity(CityModel city);
        bool UpdateCity(CityModel city);
        bool DeleteCity(int id);

        // Image-related methods
        string GetCityImagePath(int cityId);
        bool SaveCityImagePath(int cityId, string imagePath);
    }
}
