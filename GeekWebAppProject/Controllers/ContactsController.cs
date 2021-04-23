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
        public ActionResult Index(ContactMessage contactMessage)
        {
            if (ModelState.IsValid)
            {
                ContactMessage contMess = _geekDbContext.ContactMessages.GetContactMessage(contactMessage);
                if (contMess == null)
                {
                    ContactMessage conMess = new ContactMessage
                    {
                        Email = contactMessage.Email,
                        Name = contactMessage.Name,
                        Subject = contactMessage.Subject,
                        Text = contactMessage.Text

                    };
                    _geekDbContext.ContactMessages.Add(conMess);
                    _geekDbContext.SaveChanges();
                    return View();
                }
            }
            return View();
        }
    }
}