using GeekWebAppProject.Data;
using GeekWebAppProject.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly GeekDbContext _geekDbContext;
        private int _ItemPerPage;

        public PortfolioController()
        {
            _geekDbContext = new GeekDbContext();
            _ItemPerPage = 5;
        }
        // GET: Portfolio
        public ActionResult Index(int page = 2)
        {
            return View(_geekDbContext.GetWorkModelData(page, _ItemPerPage));
        }
    }
}