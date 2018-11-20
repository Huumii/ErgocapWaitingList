using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaitingList.Models.People
{
    public class PeopleModels : BaseModels
    {
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string HandyNumber { get; set; }
        public string MailAdresse { get; set; }
    }
}