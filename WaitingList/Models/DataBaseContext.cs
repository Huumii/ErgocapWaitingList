using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WaitingList.Models.List;
using WaitingList.Models.People;

namespace WaitingList.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<WaitingListModels> WaitingLists { get; set; }
        public DbSet<PatientsModels> Patients { get; set; }
        public DbSet<ParentModels> Parents { get; set; }
        public DbSet<PeopleModels> Peoples { get; set; }
        public DbSet<WishDateModels> WishDates { get; set; }
    }
}