namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DotaHeroAttr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DotaHeroAttributes",
                c => new
                    {
                        AttributeId = c.Long(nullable: false, identity: true),
                        Attribute = c.String(nullable: false),
                        Description = c.String(),
                        Id = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AttributeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DotaHeroAttributes");
        }
    }
}
