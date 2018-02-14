using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testing.Models.AdminManageModels
{
    public class Driver
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        public double PhoneNumber { get; set; }

        [Required(ErrorMessage = "Bus Number is required.")]
        public double BusNumber { get; set; }

        public string password { get; set; }
    }
}
