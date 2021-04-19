using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public class GeekDbContext : DbContext
    {
        public GeekDbContext():base("myDbConnection")
        {
            
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SkillsModel> SkillsModels { get; set; }
        public DbSet<ValuableClients> ValuableClients { get; set; }
        public DbSet<WorkModel> WorkModels { get; set; }
        public DbSet<ContactsModel> ContactsModels { get; set; }
    }
}