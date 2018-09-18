using System.Configuration;
using System.Data.Entity;

namespace DatingApplication.Models
{
    public class DatingContext : DbContext
    {
        public DatingContext(): base(ConfigurationManager.AppSettings["ConnectingString"])
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DatingContext>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}