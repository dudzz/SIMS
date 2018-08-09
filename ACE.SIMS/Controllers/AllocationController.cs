using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACE.SIMS.Controllers
{
    public class AllocationController : Controller
    {
        [HttpGet]
        public ActionResult UploadRules()
        {
            /* Not used.. AJAX called is used to populate the Dropdown list
            List<SelectListItem> objItems = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Incremental", Value = "I", Selected = true },
                new SelectListItem { Text = "Full Load", Value = "F"}
            };
            ViewBag.UploadType = objItems;
            
            List<SelectListItem> objFYFMItems = new List<SelectListItem>()
            {
                new SelectListItem { Text = "June 2018", Value = "06:2018", Selected = true },
                new SelectListItem { Text = "May 2018", Value = "05:2018"},
                new SelectListItem { Text = "April 2018", Value = "04:2018"},
                new SelectListItem { Text = "March 2018", Value = "03:2018"},
                new SelectListItem { Text = "February 2018", Value = "02:2018"},
                new SelectListItem { Text = "January 2018", Value = "01:2018"}
            };
            ViewBag.FYFM = objFYFMItems;

            List<SelectListItem> objProfitCenterItems = new List<SelectListItem>()
            {
                new SelectListItem { Text = "DNDG", Value = "DNDG", Selected = true },
                new SelectListItem { Text = "AUTG", Value = "AUTG"},
                new SelectListItem { Text = "APLG", Value = "APLG"}                
            };
            ViewBag.ProfitCenterGroup = objProfitCenterItems;
            */
            return View();
        }

        [HttpPost]
        public ActionResult UploadRules(string remittanceDate)
        {
            if (Request.Files.Count > 0)
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var files = Request.Files[i];
                    var fileName = Path.GetFileName(files.FileName);
                    //var newFileName = TextFile.GenerateNewFileName();
                    var path = Path.Combine(Server.MapPath("~/UploadedFiles/"), fileName); // uploaded filename
                    //var path = Path.Combine(Server.MapPath("~/UploadedFiles/"), newFileName); // new file name in "000000.txt" format
                    files.SaveAs(path);

                    //TextFile.Save(fileName, newFileName, remittanceDate);
                    /*
                    if (TextFile.SendUploadNotification())
                        return Json(new { success = true, emailsent = true, message = "File uploaded successfully" }, JsonRequestBehavior.AllowGet);
                    else
                        return Json(new { success = true, emailsent = false, message = "File uploaded successfully but unable to send email notification." }, JsonRequestBehavior.AllowGet);
                    */

                    return Json(new { success = true, emailsent = true, message = "File uploaded successfully" }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { success = false, message = "No file to upload!!" }, JsonRequestBehavior.AllowGet);
            }
            return null;
        }

        [HttpPost]
        public JsonResult GetUploadTypes(string selectedIndex)
        {
            List<SelectListItem> objItems = new List<SelectListItem>();
            if (selectedIndex == "0")
            {
                objItems.Add(new SelectListItem { Text = "Incremental", Value = "I", Selected = true });
                objItems.Add(new SelectListItem { Text = "Full Load", Value = "F" });
            }
            else
            {
                objItems.Add(new SelectListItem { Text = "Incremental", Value = "I", Selected = true });
            }            
            return Json(objItems, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProfitCenterGroups()
        {  
            List<SelectListItem> objProfitCenterItems = new List<SelectListItem>()
            {
                new SelectListItem { Text = "DNDG", Value = "DNDG", Selected = true },
                new SelectListItem { Text = "AUTG", Value = "AUTG"},
                new SelectListItem { Text = "APLG", Value = "APLG"}
            };
            return Json(objProfitCenterItems, JsonRequestBehavior.AllowGet);  
        }

        [HttpPost]
        public JsonResult GetFiscalYearMonths(string profitCenterGroup)
        {  
            List<SelectListItem> objFYFMItems = new List<SelectListItem>();
            if (profitCenterGroup == "DNDG")
            {
                objFYFMItems.Add(new SelectListItem { Text = "June 2018", Value = "06:2018", Selected = true });
                objFYFMItems.Add(new SelectListItem { Text = "May 2018", Value = "05:2018" });
                objFYFMItems.Add(new SelectListItem { Text = "April 2018", Value = "04:2018" });
                objFYFMItems.Add(new SelectListItem { Text = "March 2018", Value = "03:2018" });
                objFYFMItems.Add(new SelectListItem { Text = "February 2018", Value = "02:2018" });
                objFYFMItems.Add(new SelectListItem { Text = "January 2018", Value = "01:2018" });
            }
            else if (profitCenterGroup == "AUTG")
            {
                objFYFMItems.Add(new SelectListItem { Text = "June 2018", Value = "06:2018", Selected = true });
                objFYFMItems.Add(new SelectListItem { Text = "May 2018", Value = "05:2018" });
                objFYFMItems.Add(new SelectListItem { Text = "April 2018", Value = "04:2018" });
            }
            else if (profitCenterGroup == "APLG")
            {
                objFYFMItems.Add(new SelectListItem { Text = "June 2018", Value = "06:2018", Selected = true });
                objFYFMItems.Add(new SelectListItem { Text = "May 2018", Value = "05:2018" });
            }

            return Json(objFYFMItems, JsonRequestBehavior.AllowGet);
        }  





    // GET: Allocation
    public ActionResult Index()
        {
            return View();
        }

        // GET: Allocation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Allocation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Allocation/Create
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

        // GET: Allocation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Allocation/Edit/5
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

        // GET: Allocation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Allocation/Delete/5
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
