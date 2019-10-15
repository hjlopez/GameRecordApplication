namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Games : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Long(nullable: false, identity: true),
                        GameName = c.String(),
                        GameType = c.String(),
                        MaxPlayers = c.Int(nullable: false),
                        HasSeason = c.Boolean(nullable: false),
                        Id = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GameId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
