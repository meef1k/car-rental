using car_rental.Data;
using car_rental.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Controllers
{
    public class RentalController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RentalController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Rental> objList = _db.Rental;
            return View(objList);
        }
        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }
        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Rental obj)
        {
            _db.Rental.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
