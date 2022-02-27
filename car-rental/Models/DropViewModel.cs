using car_rental.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Models
{
    public class DropViewModel
    {
        public int CarId { get; set; }
        public int Name { get; set; }
        public IEnumerable<SelectListItem> ListOfCars { get; set; }
    }
}
