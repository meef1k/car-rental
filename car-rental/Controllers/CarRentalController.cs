using car_rental.Data;
using car_rental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewBag.ListofCars = _db.Cars;
            ViewBag.ListofRentals = _db.Rental;
            return View();
        }
        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CarRental obj)
        {
            if (ModelState.IsValid)
            {
                _db.CarRental.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            ViewBag.ListofCars = _db.Cars;
            ViewBag.ListofRentals = _db.Rental;
            if (id == null)
            {
                return NotFound();
            }
            var obj = _db.CarRental.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CarRental obj)
        {
            if (ModelState.IsValid)
            {
                _db.CarRental.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            ViewBag.ListofCars = _db.Cars;
            ViewBag.ListofRentals = _db.Rental;
            if (id == null)
            {
                return NotFound();
            }
            var obj = _db.CarRental.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST - DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var obj = _db.CarRental.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.CarRental.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
