using CityInfoAPI.Models;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get;  }= new CitiesDataStore();
        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name= "New York City",
                    Description= "The one with that big park",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in ..............."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointOfInterests= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral of our Lady",
                            Description = "A Gothic style Cathedral ....................",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Antwerp Centarl Station",
                            Description = " The finset example of railway ............."
                        }
                    }

                }
            };
        }
        
    }
}
