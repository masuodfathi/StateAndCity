namespace StateAndCity.Models
{
    public class StateModel
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public List<CityModel> Cities { get; set; }
    }
}
