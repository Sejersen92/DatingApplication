using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatingApplication.Models
{
    public class DatingContext : DbContext
    {
        public DatingContext() : base()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messgaes { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}