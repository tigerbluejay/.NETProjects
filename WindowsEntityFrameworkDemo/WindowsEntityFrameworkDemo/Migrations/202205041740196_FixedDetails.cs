namespace WindowsEntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Ciudad_CiudadId", c => c.Int());
            CreateIndex("dbo.Cliente", "Ciudad_CiudadId");
            AddForeignKey("dbo.Cliente", "Ciudad_CiudadId", "dbo.Ciudad", "CiudadId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "Ciudad_CiudadId", "dbo.Ciudad");
            DropIndex("dbo.Cliente", new[] { "Ciudad_CiudadId" });
            DropColumn("dbo.Cliente", "Ciudad_CiudadId");
        }
    }
}
