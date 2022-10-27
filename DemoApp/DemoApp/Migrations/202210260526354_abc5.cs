namespace DemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserInfoes", "Supervisor_Id", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
        }
    }
}
