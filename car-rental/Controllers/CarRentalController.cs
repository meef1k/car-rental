using car_rental.Data;
using car_rental.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_rental.Controllers
{
    public class CarRentalController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CarRentalController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<CarRental> objList = _db.CarRental;
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
        public IActionResult Create(CarRental obj)
        {
            _db.CarRental.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
