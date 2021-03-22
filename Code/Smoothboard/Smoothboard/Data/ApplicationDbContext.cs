using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Smoothboard.Models;

namespace Smoothboard.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Smoothboard.Models.Surfboard> Surfboard { get; set; }
        public DbSet<Smoothboard.Models.Materiaal> Materiaal { get; set; }
    }
}
