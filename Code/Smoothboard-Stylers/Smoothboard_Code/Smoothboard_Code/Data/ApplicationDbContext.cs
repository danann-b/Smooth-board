using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Smoothboard_Code.Models;

namespace Smoothboard_Code.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Smoothboard_Code.Models.Surfboard> Surfboard { get; set; }
        public DbSet<Smoothboard_Code.Models.Materiaal> Materiaal { get; set; }
    }
}
