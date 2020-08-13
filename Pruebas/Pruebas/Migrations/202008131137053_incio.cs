namespace Pruebas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class incio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campaña",
                c => new
                    {
                        CampañaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraInicio = c.DateTime(nullable: false),
                        HoraFin = c.DateTime(nullable: false),
                        DuracionImagen = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CampañaId);
            
            CreateTable(
                "dbo.Imagens",
                c => new
                    {
                        ImagenId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        RutaImagen = c.String(),
                        Campaña_CampañaId = c.Int(),
                    })
                .PrimaryKey(t => t.ImagenId)
                .ForeignKey("dbo.Campaña", t => t.Campaña_CampañaId)
                .Index(t => t.Campaña_CampañaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Imagens", "Campaña_CampañaId", "dbo.Campaña");
            DropIndex("dbo.Imagens", new[] { "Campaña_CampañaId" });
            DropTable("dbo.Imagens");
            DropTable("dbo.Campaña");
        }
    }
}
