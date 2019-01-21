namespace FoodGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RestaurentReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating = c.Double(nullable: false),
                        Comment = c.String(),
                        RestaurentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurents", t => t.RestaurentID, cascadeDelete: true)
                .Index(t => t.RestaurentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestaurentReviews", "RestaurentID", "dbo.Restaurents");
            DropIndex("dbo.RestaurentReviews", new[] { "RestaurentID" });
            DropTable("dbo.RestaurentReviews");
            DropTable("dbo.Restaurents");
        }
    }
}
