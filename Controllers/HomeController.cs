﻿using PartyInvites.Models;
using System;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour < 12 ? "Good Morning" : "Goood Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO:Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            { //there is a validation error
                return View();
            }
        }

    }
}