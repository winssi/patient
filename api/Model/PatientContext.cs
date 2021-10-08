using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft;
using Model;

namespace Model
{
    public class PatientContext : DbContext
    {
        public DbSet<Patient> Patients{ get ; set ;}
        public DbSet<UserP> UserPs{ get ; set ;}
        private const string DbPath = "database.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
  
    }

}