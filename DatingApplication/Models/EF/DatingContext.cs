using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatingApplication.Models
{
    public class DatingContext : DbContext
    {
        public DatingContext(): base(ConfigurationManager.AppSettings["ConnectionString"])
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DatingContext>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}