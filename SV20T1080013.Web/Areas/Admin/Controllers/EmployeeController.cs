using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SV20T1080013.Web.Areas.Admin.Controllers
{

    /// <summary>
    /// 
    /// </summary>

    [Area("Admin")]

    public class Employee : Controller
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Title = " Bổ Sung Nhân Viên";
            return View();
        }
        public IActionResult Edit()
        {
            ViewBag.Title = "Cập Nhật Nhân Viên";
            return View("Create");
        }
        public IActionResult Delete(int id = 0)
        {
            return View();
        }

    }


}

