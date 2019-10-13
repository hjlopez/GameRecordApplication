namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GTTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Type = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GameTypes");
        }
    }
}
