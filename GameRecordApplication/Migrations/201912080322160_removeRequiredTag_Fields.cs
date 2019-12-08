namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeRequiredTag_Fields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fields", "Module", c => c.String());
            AlterColumn("dbo.Fields", "FieldName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fields", "FieldName", c => c.String(nullable: false));
            AlterColumn("dbo.Fields", "Module", c => c.String(nullable: false));
        }
    }
}
