using HopestoneApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HopestoneApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Icon { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        //[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //[DateVal(ErrorMessage = "Back date or advance entry not allowed")]
        public DateTime Created { get; set; }

        [Required]
        //[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //[DateVal(ErrorMessage = "Back date or advance entry not allowed")]
        public DateTime Updated { get; set; }

        [Display(Name = "Item Status")]
        [Required]
        public bool IsActive { get; set; }
    }
}