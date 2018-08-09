using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACE.SIMS.Controllers
{
    public class CMController : Controller
    {

        [HttpGet]
        public ActionResult CMList()
        {
            return View();
        }
        // GET: CM
        public ActionResult Index()
        {
            return View();
        }

        // GET: CM/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CM/Create
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

        // GET: CM/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CM/Edit/5
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

        // GET: CM/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CM/Delete/5
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
