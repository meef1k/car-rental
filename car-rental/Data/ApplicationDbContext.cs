using car_rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CarRental> CarRental { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Rental> Rental { get; set; }

    }
}
