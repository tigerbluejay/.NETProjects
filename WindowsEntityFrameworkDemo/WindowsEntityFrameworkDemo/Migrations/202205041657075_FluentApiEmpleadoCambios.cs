namespace WindowsEntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApiEmpleadoCambios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        IdEmpleado = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.IdEmpleado);
            
            AlterColumn("dbo.Cliente", "FechadeNacimiento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "FechadeNacimiento", c => c.DateTime(nullable: false));
            DropTable("dbo.Empleado");
        }
    }
}
