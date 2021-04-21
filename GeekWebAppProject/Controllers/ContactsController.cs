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
                    ModelState.AddModelError("", "This user does not exist");
                    ContactMessage conMess = new ContactMessage
                    {
                        Id = contactMessage.Id,
                        Email = contactMessage.Email,
                        Name = contactMessage.Name,
                        Subject = contactMessage.Subject,
                        Text = contactMessage.Text

                    };
                    _geekDbContext.ContactMessages.Add(conMess);
                    return View();
                }
                else
                {
                    Session.Add("message", contMess);
                }
            }
            return View();
        }
    }
}