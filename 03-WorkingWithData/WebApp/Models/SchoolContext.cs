using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace WebApp.Models
{
    public partial class SchoolContext : DbContext
    {
        private readonly IConfiguration configuration;

        public SchoolContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public SchoolContext(DbContextOptions<SchoolContext> options, IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SchoolClass> SchoolClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultMSSQLConnection"));
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultSqlLiteConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<SchoolClass>().ToTable("SchoolClass");
        }
    }
}
