using GeekWebAppProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class MenuController : Controller
    {
        //private readonly GeekDbContext _geekDbContext;

        //public MenuController()
        //{
        //    _geekDbContext = new GeekDbContext();
        //}
        //public ActionResult Index()
        //{
        //    var menus = _geekDbContext.Menus;
        //    return View(menus);
        //}
        public ActionResult Index()
        {
            return View();
        }
    }
}