namespace FoodGallery.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodGallery.Models.EntityDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "FoodGallery.Models.EntityDB";
        }

        protected override void Seed(FoodGallery.Models.EntityDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Restaurents.AddOrUpdate( r => r.Name,

                new Restaurent { Name = "Tim Horton", City = "Winnipeg", Country = "Canada",
                    Reviews = new List<RestaurentReview> {
                      new RestaurentReview { Rating = 8.5, Comment = "Best Coffee" , Reviewer = "John"},
                      new RestaurentReview { Rating = 9, Comment = "You should try Timbit!!"} 
                    } 
                    },

                new Restaurent { Name = "Copper Chimny", City = "Winnipeg", Country = "Canada" },
                new Restaurent { Name = "Tim", City = "Regina", Country = "Canada" },

                new Restaurent { Name = "Star Kabab", City = "Dhaka", Country = "Bangladesh",
                    Reviews = new List<RestaurentReview> {
                      new RestaurentReview { Rating = 9.5, Comment = "Best Kacchi", Reviewer = "Sibendu"},
                      new RestaurentReview { Rating = 10, Comment = "Awsome Legrost", Reviewer = "Km"},
                      new RestaurentReview { Rating = 9, Comment = "Must try Faluda!"}
                    }
                },

                new Restaurent { Name = "Bukit Bintan", City = "Kualalampur", Country = "Malaysia" }


                );

        }
    }
}
