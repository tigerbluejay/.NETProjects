namespace WindowsEntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelosAdicionales : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FacturaDetalles",
                c => new
                    {
                        IdFacturaDetalle = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Factura_Id = c.Int(),
                        Producto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdFacturaDetalle)
                .ForeignKey("dbo.Factura", t => t.Factura_Id)
                .ForeignKey("dbo.Producto", t => t.Producto_Id)
                .Index(t => t.Factura_Id)
                .Index(t => t.Producto_Id);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaFactura = c.DateTime(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        FechadeNacimiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacturaDetalles", "Producto_Id", "dbo.Producto");
            DropForeignKey("dbo.FacturaDetalles", "Factura_Id", "dbo.Factura");
            DropForeignKey("dbo.Cliente", "Id", "dbo.Usuario");
            DropForeignKey("dbo.Factura", "Cliente_Id", "dbo.Cliente");
            DropIndex("dbo.Cliente", new[] { "Id" });
            DropIndex("dbo.Factura", new[] { "Cliente_Id" });
            DropIndex("dbo.FacturaDetalles", new[] { "Producto_Id" });
            DropIndex("dbo.FacturaDetalles", new[] { "Factura_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Cliente");
            DropTable("dbo.Factura");
            DropTable("dbo.FacturaDetalles");
        }
    }
}
