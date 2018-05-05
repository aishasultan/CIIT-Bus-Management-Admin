using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testing.Models.AdminManageModels
{
    public class Routes
    {
        [Display(Name = "Bus Number")]
        public double busNumber { get; set; }
        [Display(Name = "Route Name")]
        public string routeName { get; set; }
        [Display(Name = "Bus Stop")]
        public string busStop { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
    }
}
