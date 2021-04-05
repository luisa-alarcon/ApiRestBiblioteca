using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi_Biblioteca.GUI.Models;

namespace WebApi_Biblioteca.GUI.Controllers
{
    public class PublicacionController : Controller
    {
        
        // GET: Publicacion
        public ActionResult Index()
        {
            return View();
        }

        // GET: Publicacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Publicacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publicacion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publicacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Publicacion/Edit/5
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

        // GET: Publicacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Publicacion/Delete/5
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
