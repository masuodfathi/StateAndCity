using StateAndCity.Data;
using StateAndCity.Interfaces;
using StateAndCity.Models;

namespace StateAndCity.Repository
{
    public class StateRepository : IStateRepository
    {
        private readonly DataContext _context;

        public StateRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<CityModel> GetCitiesByState(string stateName)
        {
            return _context.Cities.Where(c => c.State.StateName == stateName).ToList();
        }

        public ICollection<CityModel> GetCitiesByState(int stateId)
        {
            return _context.Cities.Where(c => c.StateId == stateId).ToList();
        }

        public StateModel GetState(int id)
        {
            return _context.States.Where(s => s.StateId == id).SingleOrDefault();
        }

        public StateModel GetState(string stateName)
        {
            return _context.States.Where(s => s.StateName == stateName).SingleOrDefault();
        }

        public ICollection<StateModel> GetStates()
        {
            return _context.States.ToList();
        }
    }
}
