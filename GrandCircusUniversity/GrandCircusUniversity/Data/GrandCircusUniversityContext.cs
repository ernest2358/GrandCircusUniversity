﻿using GrandCircusUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandCircusUniversity.Data
{
    public class GrandCircusUniversityContext : DbContext
    {
        public GrandCircusUniversityContext(DbContextOptions<GrandCircusUniversityContext> options) 
            : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }

        public DbSet<GrandCircusUniversity.Models.Login> Login { get; set; }
    }
}
