
using Common;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<Activity> activities {get;set;}
    }
}