using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCrud.Models
{
    public class Student
    {
        [Display(Name ="Please Enter Your Name")]
        [Required]
        public string name { get; set; }

        [Display(Name = "Please Enter Collage Name")]
        [Required]

        public string Collage { get; set; }
        [DataType(DataType.Date)]
        [Required]

        public DateTime DateOfBirth { get; set; }


        [Display(Name ="Please Enter Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string email { get; set; }
        [Display(Name = "Please Enter Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Mobile { get; set; }

       
    }
}