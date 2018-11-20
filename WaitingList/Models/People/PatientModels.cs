using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Waitlist.Models.People;

namespace Waitlist.Models
{
    public enum GenderEnum
    {
        NotSpecified,
        Male,
        Female
    }

    public class PatientsModels : BaseModels
    {
        public PeopleModels PersonalInfos { get; set; }
        public virtual List<ParentModels> Parents { get; set; }
    }
}