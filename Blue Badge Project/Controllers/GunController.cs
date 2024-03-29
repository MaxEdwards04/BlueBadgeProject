﻿using Blue_Badge_Project.Models;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blue_Badge_Project.Controllers
{
    public class GunController : Controller
    {
        // GET: Gun
        [Authorize]
        public ActionResult Index()
        {
            var model = new GunListItem[0];
            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GunCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}