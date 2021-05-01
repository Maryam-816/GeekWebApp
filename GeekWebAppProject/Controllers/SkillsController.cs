using GeekWebAppProject.Data;
using GeekWebAppProject.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class SkillsController : Controller
    {
        private readonly GeekDbContext _geekDbContext;
        private int _ItemPerPage;

        public SkillsController()
        {
            _geekDbContext = new GeekDbContext();
            _ItemPerPage = 5;
        }
        // GET: Skills
        public ActionResult Index(int page = 3)
        {
            return View(_geekDbContext.GetSkillsModelData(page, _ItemPerPage));
        }
    }
}