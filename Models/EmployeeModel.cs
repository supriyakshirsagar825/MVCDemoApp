using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Display(Name="Please enter Name ")]
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsOnline { get; set; }
        public int Salary { get; set; }
        public bool IsEmployee { get; set; }
        public string Address { get; set; }

        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }

    }
}