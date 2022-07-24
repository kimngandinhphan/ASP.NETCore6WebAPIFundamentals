using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto() { Id = 1, Name = "New York City", Description = "The one is the most populous city in the United States."},
                new CityDto() { Id = 2, Name = "Ho Chi Minh City", Description= "The one also known by its former name Saigon, is the largest city in Vietnam. "}
            };
        }
    }
}
