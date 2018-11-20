using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaitingList.Models
{
    public class BaseModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}