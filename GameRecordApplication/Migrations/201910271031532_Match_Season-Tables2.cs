namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Match_SeasonTables2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        MatchId = c.Long(nullable: false, identity: true),
                        GameId = c.Long(nullable: false),
                        SeasonId = c.Long(nullable: false),
                        PlayerWin = c.Long(nullable: false),
                        PlayerIdLose = c.Long(nullable: false),
                        Hero = c.String(),
                        Weapon = c.String(),
                        TeamWin = c.Boolean(nullable: false),
                        Hours = c.Int(nullable: false),
                        Minutes = c.Int(nullable: false),
                        Seconds = c.Int(nullable: false),
                        Id = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MatchId);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SeasonNumber = c.Long(nullable: false),
                        GameId = c.Long(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Seasons");
            DropTable("dbo.Matches");
        }
    }
}
