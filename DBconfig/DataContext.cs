using GatesControl.Models;
using System.Data.Entity;

namespace GatesControl.DBconfig
{
    public class DataContext : DbContext
    {
        //one dataset prop for each table:
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Event> Events { get; set; }

    }
}
