
using EetdagenKassa.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace EetdagenKassa.DAL
{
    public class KassaContext : DbContext
     {
        //The name of the connection string (which you'll add to the Web.config file later) is passed in to the constructor.
        public KassaContext(): base ("KassaContext")
            { }

        public DbSet<Bestelling> Bestellings { get; set; }
        public DbSet<Gerecht> Gerechts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}