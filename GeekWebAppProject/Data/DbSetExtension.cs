using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public static class DbSetExtension
    {
        public static ContactMessage GetContactMessage(this DbSet<ContactMessage> _contactMessages, ContactMessage contactMessage)
        {
            if (!_contactMessages.Any(q => q.Text == contactMessage.Text))
            {
                return null;
            }

            else
            {
                return (ContactMessage)_contactMessages.Where(q => q.Text == contactMessage.Text);
            }
        }
    }
}