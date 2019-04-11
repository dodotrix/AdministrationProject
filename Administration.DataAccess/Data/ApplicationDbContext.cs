using Administration.Domena.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Administration.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pacijent> Pacijenti { get; set; }
        public DbSet<Zahvat> Zahvati { get; set; }
        public DbSet<PacijentZahvat> PacijentZahvati { get; set; }
    }
}
