﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReservationApp.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationRepository repo;

        public ReservationController(IReservationRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetReservations();

            return View(products);
        }
        public IActionResult ViewReservation(int id)
        {
            var res = repo.GetReservation(id);

            return View(res);
        }
        public IActionResult UpdateReservation(int id)
        {
            Reservation res = repo.GetReservation(id);

            if (res == null)
            {
                return View("ReservationNotFound");
            }

            return View(res);
        }

        public IActionResult UpdateReservationToDatabase(Reservation res)
        {
            repo.UpdateReservation(res);

            return RedirectToAction("ViewReservation", new { id = res.ID });
        }

        public IActionResult InsertReservation()
        {
            var res = repo.AssignTimeSlot();

            return View(res);
        }

        public IActionResult InsertReservationToDatabase(Reservation reservationToInsert)
        {
            repo.InsertReservation(reservationToInsert);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteReservation(Reservation reservation)
        {
            repo.DeleteReservation(reservation);

            return RedirectToAction("Index");
        }



    }
}
