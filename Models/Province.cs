using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Map.Models
{
    public class Province
    {
        [Display(Name = "Province Code")]
        [Key]
        public string ProvinceCode {get; set;}

        [Display(Name = "Province Name")]
        public string ProvinceName {get; set;}

        public List<City> Cities {get; set;}
    }
}