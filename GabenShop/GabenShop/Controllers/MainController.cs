using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GabenShop.Models;
namespace GabenShop.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        [HttpGet]        
        public ActionResult Index()
        {
            MainModel model = new MainModel();
            model.Name = "Имя";
            return View("main", model);
        }
    }
}