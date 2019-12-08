namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldId_Fields : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Fields");
            AddColumn("dbo.Fields", "FieldId", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Fields", "Id", c => c.String());
            AddPrimaryKey("dbo.Fields", "FieldId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Fields");
            AlterColumn("dbo.Fields", "Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Fields", "FieldId");
            AddPrimaryKey("dbo.Fields", "Id");
        }
    }
}
