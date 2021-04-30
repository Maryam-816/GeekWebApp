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
        public ActionResult Index(ContactMessage comment)
        {
            if (ModelState.IsValid)
            {
                ContactMessage c = new ContactMessage
                {
                    Email = comment.Email,
                    Name = comment.Name,
                    Text = comment.Text,
                    Subject = comment.Subject
                };
                _geekDbContext.ContactMessages.Add(c);
            }

            return View();
        }
    }
}