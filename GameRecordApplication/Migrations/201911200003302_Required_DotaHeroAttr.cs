namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Required_DotaHeroAttr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DotaHeroAttributes", "Attribute", c => c.String(nullable: false));
            AlterColumn("dbo.DotaHeroAttributes", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DotaHeroAttributes", "Description", c => c.String());
            AlterColumn("dbo.DotaHeroAttributes", "Attribute", c => c.String());
        }
    }
}
