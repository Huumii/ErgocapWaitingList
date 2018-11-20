using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Waitlist.Models.List;
using Waitlist.Models.People;

namespace Waitlist.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<WaitlistModels> Waitlists { get; set; }
        public DbSet<PatientsModels> Patients { get; set; }
        public DbSet<ParentModels> Parents { get; set; }
        public DbSet<PeopleModels> Peoples { get; set; }
        public DbSet<WishDateModels> WishDates { get; set; }
    }
}