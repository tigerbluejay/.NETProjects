namespace WindowsEntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentAPIMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudad",
                c => new
                    {
                        CiudadId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.CiudadId);
            
            CreateTable(
                "dbo.Comision",
                c => new
                    {
                        ComisionID = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor = c.Int(nullable: false),
                        FechadeModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ComisionID);
            
            AddColumn("dbo.Factura", "Empleado_IdEmpleado", c => c.Int());
            AddColumn("dbo.Empleado", "CiudadId", c => c.Int(nullable: false));
            CreateIndex("dbo.Factura", "Empleado_IdEmpleado");
            CreateIndex("dbo.Empleado", "CiudadId");
            AddForeignKey("dbo.Empleado", "CiudadId", "dbo.Ciudad", "CiudadId", cascadeDelete: true);
            AddForeignKey("dbo.Factura", "Empleado_IdEmpleado", "dbo.Empleado", "IdEmpleado");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factura", "Empleado_IdEmpleado", "dbo.Empleado");
            DropForeignKey("dbo.Empleado", "CiudadId", "dbo.Ciudad");
            DropIndex("dbo.Empleado", new[] { "CiudadId" });
            DropIndex("dbo.Factura", new[] { "Empleado_IdEmpleado" });
            DropColumn("dbo.Empleado", "CiudadId");
            DropColumn("dbo.Factura", "Empleado_IdEmpleado");
            DropTable("dbo.Comision");
            DropTable("dbo.Ciudad");
        }
    }
}
