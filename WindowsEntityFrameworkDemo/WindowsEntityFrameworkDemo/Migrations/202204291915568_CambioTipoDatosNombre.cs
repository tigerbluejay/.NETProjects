namespace WindowsEntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioTipoDatosNombre : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categorias", newName: "Categoria");
            RenameTable(name: "dbo.Productoes", newName: "Producto");
            AlterColumn("dbo.Categoria", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Producto", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Producto", "Precio", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Producto", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Producto", "Nombre", c => c.String());
            AlterColumn("dbo.Categoria", "Nombre", c => c.String());
            RenameTable(name: "dbo.Producto", newName: "Productoes");
            RenameTable(name: "dbo.Categoria", newName: "Categorias");
        }
    }
}
