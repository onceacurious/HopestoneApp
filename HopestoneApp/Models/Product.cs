using System;
using System.ComponentModel.DataAnnotations;

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
        public DateTime Created { get; set; }

        [Required]
        public DateTime Updated { get; set; }

        [Display(Name = "Item Status")]
        [Required]
        public bool IsActive { get; set; }
    }
}