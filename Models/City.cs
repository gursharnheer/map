using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Map.Models
{
    public class City
    {
        [Display(Name = "Id")]
        public int CityId {get; set;}

        [Display(Name = "City")]
        public string CityName {get; set;}

        public int Population {get; set;}

        [Display(Name = "Province")]
        public string ProvinceCode {get; set;}
        [ForeignKey("ProvinceCode")]

        public Province Province {get; set;}
    }
}