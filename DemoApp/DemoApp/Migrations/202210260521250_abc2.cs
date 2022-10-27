namespace DemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserInfoes", "PositionId", "dbo.Positions");
            AddForeignKey("dbo.UserInfoes", "PositionId", "dbo.Positions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "PositionId", "dbo.Positions");
            AddForeignKey("dbo.UserInfoes", "PositionId", "dbo.Positions", "Id");
        }
    }
}
