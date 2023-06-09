﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WaterProject.Models
{
    public class WaterProjectContext : DbContext
    {
        public WaterProjectContext()
        {
        }

        public WaterProjectContext(DbContextOptions<WaterProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Donation> Donations { get; set; }

    }
}
