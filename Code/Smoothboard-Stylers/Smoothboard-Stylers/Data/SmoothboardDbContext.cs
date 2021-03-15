using Microsoft.EntityFrameworkCore;
using Smoothboard_Stylers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Data
{
    public class SmoothBoardDbContext : DbContext
    {
        /// <summary>
        /// De constructor van de database context
        /// </summary>
        /// <param name="options">De optie parameters voor deze dbcontext,
        /// bijvoorbeeld de connectionstring</param>
        public SmoothBoardDbContext(DbContextOptions<SmoothBoardDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// De DbSets komen overeen met tabellen uit de database
        /// </summary>
        public DbSet<Surfboard> Surfboards { get; set; }
        public DbSet<Voorraad> Voorraden { get; set; }
        public DbSet<Materiaal> Materialen { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<FAQs> Faqs { get; set; }
        public DbSet<Filiaal> Filialen { get; set; }
        public DbSet<Interesse> Interessen { get; set; }
        public DbSet<Contact> Contacten { get; set; }
    }
}
