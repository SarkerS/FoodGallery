using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodGallery.Models
{
    public class Restaurent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<RestaurentReview> Reviews { get; set; }


    }
}