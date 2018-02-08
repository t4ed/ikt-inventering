using ikt.Models;
using System.Data.Entity;

namespace ikt.DAL
{
    public class iktContext : DbContext
    {
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ProjectClass> ProjectClasses { get; set; }
        public DbSet<Ikt> Ikts { get; set; }
    }
}