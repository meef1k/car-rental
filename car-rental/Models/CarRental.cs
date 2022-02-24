using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Models
{
    public class CarRental
    {
        [Key]
        public int CarRentalId { get; set; }
        [Display(Name = "Wynajęcie od")]
        public DateTime RentFrom { get; set; }
        [Display(Name = "Wynajęcie do")]
        public DateTime RentTo { get; set; }
        public int RentalId { get; set; }
        [ForeignKey("RentalId")]
        public Rental Rental { get; set; }
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public Cars Cars { get; set; }
    }
}
