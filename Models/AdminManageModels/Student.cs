using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testing.Models.AdminManageModels
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public string year { get; set; }

        public string program { get; set; }

        public string UserName { get; set; }

        [Required(ErrorMessage = "You Registration Number is required.")]
        public int RegNo { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        public double PhoneNumber { get; set; }

        [Required(ErrorMessage = "Bus Number is required.")]
        public double BusNumber { get; set; }
    }
}
