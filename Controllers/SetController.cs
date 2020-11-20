﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SETS.Controllers
{
    public class SetController : Controller
    {
        // GET: SetController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}