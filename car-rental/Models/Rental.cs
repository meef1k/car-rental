using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }
        [Required]
        [Display(Name = "Imię i Nazwisko")]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name = "Adres")]
        public string CustomerAddress { get; set; }
        [Required]
        [Display(Name = "Telefon")]
        public int PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Adres e-mail")]
        public string AddressEmail { get; set; }
        public List<CarRental> CarRental { get; set; }
    }
}
