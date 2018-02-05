using ikt.Models;
using System.Data.Entity;

namespace ikt.DAL
{
    public class iktContext : DbContext
    {
        public DbSet<Staff> Staff { get; set; }
    }
}