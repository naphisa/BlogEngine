namespace BlogEngine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comment1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Body", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "Body");
        }
    }
}
