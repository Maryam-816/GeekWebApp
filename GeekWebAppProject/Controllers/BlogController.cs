using GeekWebAppProject.Data;
using GeekWebAppProject.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly GeekDbContext _geekDbContext;
        private int _ItemPerPage;

        public BlogController()
        {
            _geekDbContext = new GeekDbContext();
            _ItemPerPage = 5;
        }
        // GET: Blog
        public ActionResult Index(int page = 4)
        {
            return View(_geekDbContext.GetArticlesData(page, _ItemPerPage));
        }
    }
}