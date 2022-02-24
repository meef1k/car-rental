using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Typy
{
    public enum CarType
    {
       [Display(Name = "Samochód osobowy")]
        Osobowy,
       [Display(Name = "Samochód dostawczy")]
        Dostawczy,
       [Display(Name = "Ciężarówka")]
        Ciężarówka
    }
}
