namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMatchDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matches", "PlayerWin", c => c.String());
            AlterColumn("dbo.Matches", "PlayerIdLose", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matches", "PlayerIdLose", c => c.Long(nullable: false));
            AlterColumn("dbo.Matches", "PlayerWin", c => c.Long(nullable: false));
        }
    }
}
