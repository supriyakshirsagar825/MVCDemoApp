using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Person
    {
        [Required(ErrorMessage ="Please Enter provide First Name ....")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="please enter provide Last name ....")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please provide your Age...." )]
        [Range(1, 100)]
        public int Age { get; set; }
        [Required (ErrorMessage ="please provide your Email address....") ]
        [EmailAddress]
        
        public string Email { get; set; }
        [Required(ErrorMessage ="please provide your salary....")]
       
        public int Salary { get; set; }
    }
}