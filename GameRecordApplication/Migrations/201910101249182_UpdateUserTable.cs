namespace GameRecordApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ProfilePic", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ProfilePic");
        }
    }
}
