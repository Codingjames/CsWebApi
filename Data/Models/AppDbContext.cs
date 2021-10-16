using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore;

namespace JApi.Data.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Customer> Customers { get; set; }
    }
}