namespace WindowsEntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bdRelaciones : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producto", "Categoria_Id", c => c.Int());
            CreateIndex("dbo.Producto", "Categoria_Id");
            AddForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria", "Id");
            DropColumn("dbo.Producto", "CategoriaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Producto", "CategoriaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "Categoria_Id" });
            DropColumn("dbo.Producto", "Categoria_Id");
        }
    }
}
