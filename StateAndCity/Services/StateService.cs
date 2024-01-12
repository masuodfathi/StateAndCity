using StateAndCity.Interfaces;
using StateAndCity.Models;

namespace StateAndCity.Services
{
    public class StateService : IStateService
    {
        private readonly IStateRepository _stateRepository;

        public StateService(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public ICollection<StateModel> GetStates()
        {
            return _stateRepository.GetStates();
        }

        public StateModel GetState(int id)
        {
            return _stateRepository.GetState(id);
        }

        public StateModel GetState(string stateName)
        {
            return _stateRepository.GetState(stateName);
        }

        public ICollection<CityModel> GetCitiesByState(string stateName)
        {
            return _stateRepository.GetCitiesByState(stateName);
        }

        public ICollection<CityModel> GetCitiesByState(int id)
        {
            return _stateRepository.GetCitiesByState(id);
        }
    }
}
