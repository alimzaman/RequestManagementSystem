﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Models.EntityModels;

namespace RMS.App.ViewModels
{
    public class RequisitionViewModel 
    {
        public int Id { get; set; }

        [Display(Name = "Requisition Number")]
        public string RequisitionNumber { get; set; }

        [Required(ErrorMessage = "Please provide a journey start place details!")]
        [Display(Name = "From Place")]
        public string FromPlace { get; set; }

        [Required(ErrorMessage = "Please provide a journey destination details!")]
        [Display(Name = "Destination")]
        public string DestinationPlace { get; set; }

        [Required(ErrorMessage = "Please provide a journey start date and time!")]
        [Display(Name = "Journey Date")]
        public DateTime StartDateTime { get; set; }
        
        [Display(Name = "Journey Time")]
        [Required(ErrorMessage = "Please set a journey time!")]
        public string StartTime { get; set; }

        [Required(ErrorMessage = "Please provide a journey end date and time!")]
        [Display(Name = "Return Date")]
        public DateTime EndDateTime { get; set; }

        [Display(Name = "Return Time")]
        [Required(ErrorMessage = "Please set a return time!")]
        public string EndTime { get; set; }

        [Required(ErrorMessage = "Please provide a short journey description!")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [Display(Name = "Request For")]
        public string RequestFor { get; set; }

        [Display(Name = "Employee")]
        [Required(ErrorMessage = "Please select Employee!")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        public List<RequisitionViewModel> RequisitionViewModels { get; set; }

        public string GetRequisitionNumber()
        {
            string requestNumber = DateTime.Now.ToString("HHmmssMMddyyyy");
            return requestNumber;
        }
    }
}
