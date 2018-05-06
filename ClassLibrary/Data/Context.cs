using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options ) : base(options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
