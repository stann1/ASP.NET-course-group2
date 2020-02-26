﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Student>().ToTable("Students");
            builder.Entity<Course>().ToTable("Courses");

            // seed the database
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole {Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole {Id = "2", Name = "Teacher", NormalizedName = "TEACHER" }
            );
        }
    }
}
