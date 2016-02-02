namespace MiprimerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primerquery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        CodigoCliente = c.Int(nullable: false, identity: true),
                        nombreCliente = c.String(nullable: false),
                        direccionCliente = c.String(nullable: false),
                        generoCliente = c.String(nullable: false),
                        edadCliente = c.Int(nullable: false),
                        telefonoCliente = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
