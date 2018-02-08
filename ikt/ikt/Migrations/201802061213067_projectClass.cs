namespace ikt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projectClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "ClassID", "dbo.Classes");
            DropIndex("dbo.Projects", new[] { "ClassID" });
            DropColumn("dbo.Projects", "ClassID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "ClassID", c => c.Int());
            CreateIndex("dbo.Projects", "ClassID");
            AddForeignKey("dbo.Projects", "ClassID", "dbo.Classes", "ID");
        }
    }
}
