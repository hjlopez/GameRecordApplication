namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fields : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Module = c.String(nullable: false),
                        FieldName = c.String(nullable: false),
                        AciveField = c.Boolean(nullable: false),
                        IsRequired = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fields");
        }
    }
}
