using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public static class DbSetExtension
    {
        public static User GetUser(this DbSet<User> _users, ContactsModel contactsModel)
        {
            if (!_users.Any(q => q.Email == contactsModel.Email))
            {
                return null;
            }

            else
            {
                return (User)_users.Where(q => q.Email == contactsModel.Email);
            }
        }
    }
}