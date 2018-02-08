namespace ikt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iktMetaDataFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ikts", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Ikts", "Comment", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ikts", "Comment", c => c.String(maxLength: 300));
            AlterColumn("dbo.Ikts", "Description", c => c.String(nullable: false, maxLength: 300));
        }
    }
}
