namespace ikt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subjectFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subjects", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subjects", "Name", c => c.String(nullable: false, maxLength: 25));
        }
    }
}
