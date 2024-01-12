using StateAndCity.Models;

namespace StateAndCity.Interfaces
{
    public interface ICityRepository
    {
        ICollection<CityModel> GetCities();
        CityModel GetCityById(int id);
        CityModel GetCityByName(string name);
        bool CreateCity(CityModel city);
        bool UpdateCity(CityModel city);
        bool DeleteCity(int id);

        // methods for image operations
        bool SaveCityImagePath(int cityId, string imagePath);
        string GetCityImageUrl(int cityId);

    }
}
