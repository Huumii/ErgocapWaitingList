using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Waitlist.Models.List
{
    public class WaitlistModels : BaseModels
    {
        public DateTime InsertedDate { get; set; }
        public virtual List<PatientsModels> Patients { get; set; }
        public virtual List<WishDateModels> WishDates { get; set; }
    }
}