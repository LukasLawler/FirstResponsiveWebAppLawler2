using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppLawler.Models
{

    public class Person
    {
        [Required(ErrorMessage = "Must input name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Must input birth year")]
        [Range(1900, 2021, ErrorMessage = "Birth year must be between 1900 and 2021.")]
        public int? BirthYear { get; set; }
        
        public int? AgeThisYear()
        {
            int CURRENTYEAR = 2021;
            int? currentAge = CURRENTYEAR - BirthYear;
            return currentAge;
        }
    }
}
