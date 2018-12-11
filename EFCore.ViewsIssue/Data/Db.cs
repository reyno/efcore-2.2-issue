using EFCore.ViewsIssue.Data.Entities;
using EFCore.ViewsIssue.Data.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCore.ViewsIssue.Data
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options)
        { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbQuery<PeopleWithAddressView> PeopleWithAddress { get; set; }

        
    }

    public class DbFactory : IDesignTimeDbContextFactory<Db>
    {
        public Db CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Db>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb;Database=crap");

            return new Db(optionsBuilder.Options);
        }
    }
}