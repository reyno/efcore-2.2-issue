using EFCore.ViewsIssue.Data;
using EFCore.ViewsIssue.Data.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EFCore.ViewsIssue
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var db = new DbFactory().CreateDbContext(args);

            var view = db
                .PeopleWithAddress
                .FromSql(@"
SELECT  *
FROM People
                ")
                .Include(x => x.Address);

            var data = await view.ToListAsync();

            Console.WriteLine("Hello World!");

        }
    }
}
