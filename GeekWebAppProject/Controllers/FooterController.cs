using GeekWebAppProject.Data;
using GeekWebAppProject.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class FooterController : Controller
    {
        private readonly GeekDbContext _geekDbContext;
        private int _ItemPerPage;

        public FooterController()
        {
            _geekDbContext = new GeekDbContext();
            _ItemPerPage = 5;
        }

        // GET: Footer
        public ActionResult Index(int page = 5)
        {
            return View(_geekDbContext.GetFooterData(page, _ItemPerPage));
        }
    }
}