using StateAndCity.Data;
using StateAndCity.Interfaces;
using StateAndCity.Models;

namespace StateAndCity.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _context;

        public CityRepository(DataContext context)
        {
            _context = context;
        }
        public bool CreateCity(CityModel city)
        {
            _context.Cities.Add(city);
            return Save();
        }

        public bool DeleteCity(int id)
        {
            var city = _context.Cities.Find(id);
            if (city != null)
            {
                _context.Cities.Remove(city);
                return Save();
            }
            return false;
        }

        public ICollection<CityModel> GetCities()
        {
            return _context.Cities.ToList();
        }

        public CityModel GetCityByName(string name)
        {
            return _context.Cities.Where(c => c.CityName == name).FirstOrDefault();
        }

        public CityModel GetCityById(int id)
        {
            return _context.Cities.Find(id);
        }

        public string GetCityImageUrl(int cityId)
        {
            return _context.Cities
            .Where(c => c.CityId == cityId)
            .Select(c => c.ImageUrl)
            .FirstOrDefault();
        }

        public bool SaveCityImagePath(int cityId, string imagePath)
        {
            var city = _context.Cities.Find(cityId);
            if (city != null)
            {
                city.ImageUrl = imagePath;
                return Save();
            }
            return false;
        }

        public bool UpdateCity(CityModel city)
        {
            _context.Cities.Update(city);
            return Save();
        }
        private bool Save()
        {
            try
            {
                var save = _context.SaveChanges();
                return save > 0 ? true : false; 
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
