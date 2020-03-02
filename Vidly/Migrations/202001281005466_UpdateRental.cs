namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRental : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            AlterColumn("dbo.Rentals", "Customer_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "Movie_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "Customer_Id");
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
            DropColumn("dbo.Rentals", "CustomerId");
            DropColumn("dbo.Rentals", "MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "MovieId", c => c.Byte(nullable: false));
            AddColumn("dbo.Rentals", "CustomerId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            AlterColumn("dbo.Rentals", "Movie_Id", c => c.Int());
            AlterColumn("dbo.Rentals", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Rentals", "Movie_Id");
            CreateIndex("dbo.Rentals", "Customer_Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id");
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
