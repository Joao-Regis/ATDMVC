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

        public RequestsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
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
