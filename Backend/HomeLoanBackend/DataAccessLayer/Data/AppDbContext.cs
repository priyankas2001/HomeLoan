using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace DataAccessLayer.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // NOTE: adding connection string as a constant!
            optionsBuilder.UseSqlServer(@"Server=.\;Database=HomeLoan;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine);
        }
        public  DbSet<User> Users { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<LoanRequirements> LoanRequirements { get; set; }
        public DbSet<PersonalIncome> PersonalIncomes { get; set; }
        public DbSet<Property> Properties { get; set; }

    }
}

