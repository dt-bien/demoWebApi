namespace DemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc33 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserInfoes", "Supervisor_Id", "dbo.UserInfoes");
            DropForeignKey("dbo.UserInfoes", "PositionId", "dbo.Positions");
            DropIndex("dbo.UserInfoes", new[] { "PositionId" });
            DropIndex("dbo.UserInfoes", new[] { "Supervisor_Id" });
            DropPrimaryKey("dbo.Positions");
            DropPrimaryKey("dbo.UserInfoes");
            AddColumn("dbo.UserInfoes", "UserInfo_FK_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Positions", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.UserInfoes", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.UserInfoes", "PositionId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.UserInfoes", "Supervisor_Id", c => c.String());
            AddPrimaryKey("dbo.Positions", "Id");
            AddPrimaryKey("dbo.UserInfoes", "Id");
            CreateIndex("dbo.UserInfoes", "PositionId");
            CreateIndex("dbo.UserInfoes", "UserInfo_FK_Id");
            AddForeignKey("dbo.UserInfoes", "UserInfo_FK_Id", "dbo.UserInfoes", "Id");
            AddForeignKey("dbo.UserInfoes", "PositionId", "dbo.Positions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.UserInfoes", "UserInfo_FK_Id", "dbo.UserInfoes");
            DropIndex("dbo.UserInfoes", new[] { "UserInfo_FK_Id" });
            DropIndex("dbo.UserInfoes", new[] { "PositionId" });
            DropPrimaryKey("dbo.UserInfoes");
            DropPrimaryKey("dbo.Positions");
            AlterColumn("dbo.UserInfoes", "Supervisor_Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.UserInfoes", "PositionId", c => c.Guid(nullable: false));
            AlterColumn("dbo.UserInfoes", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Positions", "Id", c => c.Guid(nullable: false));
            DropColumn("dbo.UserInfoes", "UserInfo_FK_Id");
            AddPrimaryKey("dbo.UserInfoes", "Id");
            AddPrimaryKey("dbo.Positions", "Id");
            CreateIndex("dbo.UserInfoes", "Supervisor_Id");
            CreateIndex("dbo.UserInfoes", "PositionId");
            AddForeignKey("dbo.UserInfoes", "PositionId", "dbo.Positions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserInfoes", "Supervisor_Id", "dbo.UserInfoes", "Id");
        }
    }
}
