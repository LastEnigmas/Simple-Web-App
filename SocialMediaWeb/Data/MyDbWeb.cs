using Microsoft.EntityFrameworkCore;
using SocialMediaWeb.Models;

namespace SocialMediaWeb.Data
{
    public class MyDbWeb : DbContext
    {
        public MyDbWeb(DbContextOptions<MyDbWeb> options ) : base( options )
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }

    }
}
