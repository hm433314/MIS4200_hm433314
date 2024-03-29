﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200_hm433314.Models;
using System.Data.Entity;

namespace MIS4200_hm433314.DAL
{
    public class MIS4200Context : DbContext
    {
        public  MIS4200Context(): base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, MIS4200_hm433314.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}