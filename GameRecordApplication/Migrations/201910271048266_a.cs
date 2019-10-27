namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matches", "TeamWin", c => c.Boolean());
            AlterColumn("dbo.Matches", "Hours", c => c.Int());
            AlterColumn("dbo.Matches", "Minutes", c => c.Int());
            AlterColumn("dbo.Matches", "Seconds", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matches", "Seconds", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "Minutes", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "Hours", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "TeamWin", c => c.Boolean(nullable: false));
        }
    }
}
