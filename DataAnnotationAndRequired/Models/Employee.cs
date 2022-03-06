using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationAndRequired.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Id is Mandatary")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Name is Mandatary")]
        [StringLength(20,MinimumLength =5)]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Age is Mandatary")]
        public int? EmployeeAge { get; set; }
        [Required(ErrorMessage = "Gender is Mandatary")]
        public string EmployeeGender { get; set; }
        [Required(ErrorMessage = "Email is Mandatary")]
        public string EmployeeEmail { get; set; }

    }
}