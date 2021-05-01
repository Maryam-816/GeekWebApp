using GeekWebAppProject.Data;
using GeekWebAppProject.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class FeedBackController : Controller
    {
        private readonly GeekDbContext _geekDbContext;
        private int _ItemPerPage;

        public FeedBackController()
        {
            _geekDbContext = new GeekDbContext();
            _ItemPerPage = 5;
        }
        // GET: FeedBack
        public ActionResult Index(int page = 2)
        {
            return View(_geekDbContext.GetFeedBackData(page, _ItemPerPage));
        }
    }
}