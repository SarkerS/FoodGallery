namespace FoodGallery.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
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
                      new RestaurentReview { Rating = 2.2, Comment = "Best Coffee" , Reviewer = "John"},
                      new RestaurentReview { Rating = 4, Comment = "You should try Timbit!!"} 
                    } 
                    },

                new Restaurent { Name = "Copper Chimny", City = "Winnipeg", Country = "Canada" },
                new Restaurent { Name = "Tim", City = "Regina", Country = "Canada" },

                new Restaurent { Name = "Star Kabab", City = "Dhaka", Country = "Bangladesh",
                    Reviews = new List<RestaurentReview> {
                      new RestaurentReview { Rating = 4.5, Comment = "Best Kacchi", Reviewer = "Sibendu"},
                      new RestaurentReview { Rating = 5, Comment = "Awsome Legrost", Reviewer = "Km"},
                      new RestaurentReview { Rating = 3, Comment = "Must try Faluda!"}
                    }
                },

                new Restaurent { Name = "Bukit Bintan", City = "Kualalampur", Country = "Malaysia" }


                );


            for (int i = 0; i < 1000; i++)
            {
               // Random rnd = new Random();

                //int num1 = rnd.Next(0, 26);
                //char c1 = (char)('A' + num1);

                //int num2 = rnd.Next(0, 24);
                //char c2 = (char)('b' + num2);

                //int num3 = rnd.Next(0, 23);
                //char c3 = (char)('c' + num3);

                //int num4 = rnd.Next(0, 22);
                //char c4 = (char)('d' + num4);

                //int num5 = rnd.Next(0, 21);
                //char c5 = (char)('e' + num5);




                context.Restaurents.AddOrUpdate(r => r.Name,

                        new Restaurent
                        {
                            Name = RandomString(7),
                            City = RandomString(9),
                            Country = RandomString(8),
                            Reviews = new List<RestaurentReview> {
                                          new RestaurentReview { Rating = random.Next(1, 6), Comment = "Good" , Reviewer = RandomString(10)},
                                          new RestaurentReview { Rating = random.Next(1, 5), Comment = "Average"}
                            }
                        });

            }

        }

        private  Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZasdfghjklmnbvcxzqwertyuiop0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
