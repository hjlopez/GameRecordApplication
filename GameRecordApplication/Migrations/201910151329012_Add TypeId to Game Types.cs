namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypeIdtoGameTypes : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.GameTypes");
            AddColumn("dbo.GameTypes", "TypeId", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.GameTypes", "Id", c => c.String());
            AddPrimaryKey("dbo.GameTypes", "TypeId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.GameTypes");
            AlterColumn("dbo.GameTypes", "Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.GameTypes", "TypeId");
            AddPrimaryKey("dbo.GameTypes", "Id");
        }
    }
}
