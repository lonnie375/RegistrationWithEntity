using Microsoft.EntityFrameworkCore;
using RegistrationWithEntity.Models;

namespace RegistrationWithEntity.Data
{
    //DbContext comes from EntityFrameworkCore 
    public class AppDbContext : DbContext 
    {
        //This constructor below identifies the database that we're using. 
        //Entity Framework can work with a number of different databases. 
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        //
        public DbSet<RegistrationPage> Registration { get; set; }
    }
}
