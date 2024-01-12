namespace StateAndCity.Models
{
    public class CityModel
    {
        public int CityId { get; set; }
        public string CityName { get; set; }


        public int StateId { get; set; }
        public StateModel State { get; set; }
    }
}
