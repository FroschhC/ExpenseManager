using ExpenseManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager
{
    public class ExpenseContext : DbContext
    {

        public DbSet<ExpenseReport> ExpenseReports { get; set; }

        public ExpenseContext(DbContextOptions<ExpenseContext> options)
    :   base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ExpenseDB;Trusted_Connection=True;");
        // }
    }
}
