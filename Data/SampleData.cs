using System.Collections.Generic;
using Map.Models;

namespace Map.Data
{
    public class SampleData
    {
        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>() 
            {
                new Province() 
                {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia"                   
                },
                new Province() 
                {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"                   
                },
                new Province() 
                {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario"                   
                }
            };

            return provinces;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() 
            {                
                new City 
                {
                    CityId       = 1,
                    CityName     = "Surry",
                    Population   = 1000,
                    ProvinceCode = "BC"
                },
                new City 
                {
                    CityId       = 2,
                    CityName     = "Calgary",
                    Population   = 1000,
                    ProvinceCode = "AB"
                },
                new City 
                {
                    CityId       = 3,
                    CityName     = "Toronto",
                    Population   = 1000,
                    ProvinceCode = "ON"
                },
                new City 
                {
                    CityId       = 4,
                    CityName     = "Richmond",
                    Population   = 1000,
                    ProvinceCode = "BC"
                },
                new City 
                {
                    CityId       = 5,
                    CityName     = "Edmonton",
                    Population   = 1000,
                    ProvinceCode = "AB"
                },
                new City 
                {
                    CityId       = 6,
                    CityName     = "Thunder Bay",
                    Population   = 1000,
                    ProvinceCode = "ON"
                },
                new City 
                {
                    CityId       = 7,
                    CityName     = "Coquitlam",
                    Population   = 1000,
                    ProvinceCode = "BC"
                },
                new City 
                {
                    CityId       = 8,
                    CityName     = "Red Deer",
                    Population   = 1000,
                    ProvinceCode = "AB"
                },
                new City 
                {
                    CityId       = 9,
                    CityName     = "Sudbury",
                    Population   = 1000,
                    ProvinceCode = "ON"
                }
            };

            return cities;
        }

    }
}