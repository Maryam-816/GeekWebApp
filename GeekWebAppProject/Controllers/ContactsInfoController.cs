using GeekWebAppProject.Data;
using GeekWebAppProject.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class ContactsInfoController : Controller
    {

        private readonly GeekDbContext _geekDbContext;
        private int _ItemPerPage;

        public ContactsInfoController()
        {
            _geekDbContext = new GeekDbContext();
            _ItemPerPage = 5;
        }
        // GET: ContactsInfo
        public ActionResult Index(int page = 5)
        {
            return View(_geekDbContext.GetContactInfoData(page, _ItemPerPage));
        }
    }
}