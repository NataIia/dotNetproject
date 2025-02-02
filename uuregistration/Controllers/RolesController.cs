﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uuregistration.Models;

namespace uuregistration.Controllers
{
    public class RolesController : Controller
    {
        // GET: Roles
        public ActionResult Index()
        {
            return View();
        }

        // GET: Roles/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Roles/Create
        public ActionResult Create()
        {
            return View(new ViewModels.RoleViewModel());
        }

        // POST: Roles/Create
        [HttpPost]
        public ActionResult Create(ViewModels.RoleViewModel vm)
        {
            try
            {
                ApplicationDbContext ctx = new ApplicationDbContext();
                ctx.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = vm.Name});
                ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Roles/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Roles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Roles/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
