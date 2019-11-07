namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsTeamGame_Column_Games : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "IsTeamGame", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "IsTeamGame");
        }
    }
}
