namespace ikt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iktseed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClassID = c.Int(),
                        ProjectID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID)
                .ForeignKey("dbo.Projects", t => t.ProjectID)
                .Index(t => t.ClassID)
                .Index(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectClasses", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectClasses", "ClassID", "dbo.Classes");
            DropIndex("dbo.ProjectClasses", new[] { "ProjectID" });
            DropIndex("dbo.ProjectClasses", new[] { "ClassID" });
            DropTable("dbo.ProjectClasses");
        }
    }
}
