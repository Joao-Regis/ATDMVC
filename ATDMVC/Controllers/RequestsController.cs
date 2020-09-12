using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATDMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ATDMVC.Controllers
{
    public class RequestsController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Request Request { get; set; }



        public RequestsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)
        {
            Request = new Request();
            if (id == null)
            {
                //create
                return View(Request);
            }

            //update
            Request = _db.Requests.FirstOrDefault(u => u.RequestID == id);
            if (Request == null)
            {
                return NotFound();
            }

            return View(Request);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Request.RequestID == 0)
                {
                    //create
                    _db.Requests.Add(Request);
                }
                else
                {
                    _db.Requests.Update(Request);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Request);
        }




        #region API Calls

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Requests.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var requestFromDb = await _db.Requests.FirstOrDefaultAsync(u => u.RequestID == id);
            if (requestFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }

            _db.Requests.Remove(requestFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete succesful" });
        }

        #endregion



    }
}
