using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodGallery.Models
{
    public class RestaurentReview
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
        public int RestaurentID { get; set; }

    }
}