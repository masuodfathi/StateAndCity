using StateAndCity.Models;

namespace StateAndCity.ViewModels
{
    public class CityViewModel
    {
        public int SelectedStateId { get; set; }
        public int SelectedCityId { get; set; }
        public List<StateModel> States { get; set; }
        public List<CityModel> Cities { get; set; }
    }
}
