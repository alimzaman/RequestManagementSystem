﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using RMS.App.Models;
using RMS.App.ViewModels.ValidationModels;
using RMS.Models.EntityModels;
using RMS.Models.EntityModels.Identity;

namespace RMS.App.ViewModels
{
    public class EmployeeViewModel 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide name!")]
        [Display(Name = "Name")]
        public string FullName { get; set; }
        

        [EmailAddress(ErrorMessage = "Email address is not valid!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide contact no!")]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Please provide NID no!")]
        public string NID { get; set; }

        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        [Display(Name = "Organization")]
        [Required(ErrorMessage = "Please select a organization!")]
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Please select a department!")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Please select a designation!")]
        public int DesignationId { get; set; }
        public Designation Designation { get; set; }

        [Display(Name = "Driving Licence")]
        public string DrivingLicence { get; set; }

        [Required(ErrorMessage = "Please provide employee type!")]
        [Display(Name = "Employee Type")]
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }


        [Required]
        public bool IsChecked { get; set; }

        [NotMapped]
        [Required]
        public AddressViewModel AddressViewModel { get; set; }

        [NotMapped]
        public List<Division> DivisionList { get; set; }

        public List<Address>Addresses { get; set; }


        [NotMapped]
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
    
}
