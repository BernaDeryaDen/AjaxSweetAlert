using AjaxSweetAlert.Models;
using Microsoft.EntityFrameworkCore;

namespace AjaxSweetAlert.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Sector> Sector { get; set; }
    }
}
