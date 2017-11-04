using EasyCrud.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EasyCrud.Contexts
{
    public class ProgrammerContext : DbContext
    {
        public ProgrammerContext(DbContextOptions<ProgrammerContext> options)
            :base(options) { }
        public ProgrammerContext(){ }
        public DbSet<Availability> Availability { get; set; }
        public DbSet<BankInfo> BankInfo { get; set; }
        public DbSet<BestTime> BestTime { get; set; }
        public DbSet<Knoledge> Knoledge { get; set; }
        public DbSet<Programmer> Programmer { get; set; }
    }
}
