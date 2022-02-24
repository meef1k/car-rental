using car_rental.Typy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Models
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }
        [Display(Name = "Marka pojazdu")]
        public string Name { get; set; }
        [Display(Name = "Numer rejestracyjny")]
        public string CarNumber { get; set; }
        [Display(Name = "Typ auta")]
        public CarType CarType { get; set; }
        [Display(Name = "Czy jest dostępny?")]
        public bool IsVisible { get; set; }
        public List<CarRental> CarRental { get; set; }
    }
}
