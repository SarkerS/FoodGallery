using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodGallery.Models
{
    public class RestaurentReview
    {
        public int Id { get; set; }
        [Range(1,5)]
        [Required]
        public double Rating { get; set; }
        public string Comment { get; set; }
        [DisplayFormat(NullDisplayText = "Aonymous")]
        public string Reviewer { get; set; }
        public int RestaurentID { get; set; }

    }
}