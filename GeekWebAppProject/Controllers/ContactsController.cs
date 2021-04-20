using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeekWebAppProject.Data;
using System.Web.Mvc;

namespace GeekWebAppProject.Controllers
{
    public class ContactsController : Controller
    {
        private GeekDbContext _geekDbContext;
        public ContactsController()
        {
            _geekDbContext = new GeekDbContext();
        }
        // GET: Contacts
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactsModel contact)
        {
            if (ModelState.IsValid)
            {
                User user = _geekDbContext.Users.GetUser(contact);
                if (user == null)
                {
                    ModelState.AddModelError("", "This user does not exist");
                    return View();
                }

            }
            return View();
        }
    }
}