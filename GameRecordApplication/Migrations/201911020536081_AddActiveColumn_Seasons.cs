namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActiveColumn_Seasons : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Seasons", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Seasons", "Active");
        }
    }
}
