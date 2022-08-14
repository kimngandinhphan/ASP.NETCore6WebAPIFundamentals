using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        //public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one is the most populous city in the United States.",
                   PointsOfInterest = new List<PointOfInterestDto>()
                   {
                       new PointOfInterestDto()
                       {
                           Id=1,    
                           Name="Central Park",
                           Description="Peaceful vibe."
                       },
                       new PointOfInterestDto()
                       {
                           Id=2,
                           Name="Statue of Liberty",
                           Description="The most iconic sight of the US."
                       }
                   }
                },
                new CityDto()
                {
                    Id=2,
                    Name = "Ho Chi Minh City",
                    Description="One of the most popular city of Vietnam.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="Motobike Riding",
                            Description="Exciting experience for foreigners."
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="Strett Foods",
                            Description="Various delicious foods with the appropreate price."
                        }
                    }
                }
            };
        }

    }
}
