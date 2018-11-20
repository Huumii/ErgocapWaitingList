using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WaitingList.Models.People;

namespace WaitingList.Models
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