using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaitingList.Models.List
{
    public class WaitingListModels : BaseModels
    {
        public DateTime InsertedDate { get; set; }
        public virtual List<PatientsModels> Patients { get; set; }
        public virtual List<WishDateModels> WishDates { get; set; }
    }
}