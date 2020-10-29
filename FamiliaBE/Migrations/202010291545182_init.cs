namespace FamiliaBE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        SubTitle = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        Current_Time = c.DateTime(nullable: false),
                        Headlines = c.Boolean(nullable: false),
                        Slideshow = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                        CategoryDesc = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                        CommentDes = c.String(nullable: false),
                        Current_Time = c.DateTime(nullable: false),
                        Trend = c.Boolean(nullable: false),
                        Anonyma = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        PostDes = c.String(nullable: false),
                        Current_Time = c.DateTime(nullable: false),
                        Headlines = c.Boolean(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Like = c.Int(nullable: false),
                        Dislike = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
            DropTable("dbo.Articles");
        }
    }
}
