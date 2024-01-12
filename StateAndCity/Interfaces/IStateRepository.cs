using StateAndCity.Models;
namespace StateAndCity.Interfaces
{
    public interface IStateRepository 
    {
        ICollection<StateModel> GetStates();
        StateModel GetState(int id);
        StateModel GetState(string stateName);
        ICollection<CityModel> GetCitiesByState(string stateName);
        ICollection<CityModel> GetCitiesByState(int id);

    }
}
