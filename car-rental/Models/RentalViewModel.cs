using car_rental.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Models
{
    public class RentalViewModel
    {
        public int RentalId { get; set; }
        public int CustomerName { get; set; }
        public IEnumerable<SelectListItem> ListOfRentals { get; set; }
    }
}
