namespace MiprimerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segundoquery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        codigoEmpleado = c.Int(nullable: false, identity: true),
                        nombreEmpleado = c.String(nullable: false),
                        passwordEmpleado = c.String(nullable: false),
                        telefonoEmpleado = c.String(nullable: false),
                        direccionEmpleado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.codigoEmpleado);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleadoes");
        }
    }
}
