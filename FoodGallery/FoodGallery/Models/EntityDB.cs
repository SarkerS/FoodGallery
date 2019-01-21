using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodGallery.Models
{
    public class EntityDB : DbContext
    {
        public DbSet<Restaurent>  Restaurents { get; set; }
        public DbSet<RestaurentReview> Reviews { get; set; }
    }
}