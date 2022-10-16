using Microsoft.EntityFrameworkCore;
using Mindash.Countdown.Web.Data.DTOS;

namespace Mindash.Countdown.Web.Data
{
    public class CountDownDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data/database.db");
        }

        public DbSet<DTOS.CountdownEvent> CountdownEvents { get; set; }
    }
}
