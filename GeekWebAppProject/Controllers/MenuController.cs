using GeekWebAppProject.Data;
using GeekWebAppProject.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class MenuController : Controller
    {
        private readonly GeekDbContext _geekDbContext;
        private int _ItemPerPage;

        public MenuController()
        {
            _geekDbContext = new GeekDbContext();
            _ItemPerPage = 5;
        }
        //public ActionResult Index()
        //{
        //    var menus = _geekDbContext.Menus;
        //    return View(menus);
        //}
        public ActionResult Index(int page = 1)
        {
            return View(_geekDbContext.GetMenuData(page, _ItemPerPage));
        }
    }
}