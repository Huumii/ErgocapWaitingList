using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Waitlist.Models.List
{
    public class WaitlistModels : BaseModels
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InsertedDate { get; set; }
        public virtual List<PatientsModels> Patients { get; set; }
        public virtual List<WishDateModels> WishDates { get; set; }
    }
}