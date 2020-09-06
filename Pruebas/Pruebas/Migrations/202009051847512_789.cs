namespace Pruebas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _789 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        BannerId = c.Int(nullable: false, identity: true),
                        NombreBanner = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraInicio = c.DateTime(nullable: false),
                        HoraFin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BannerId);
            
            CreateTable(
                "dbo.FuenteRsses",
                c => new
                    {
                        FuenteRssId = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Descripcion = c.String(),
                        RssUrl_RssUrlId = c.Int(),
                    })
                .PrimaryKey(t => t.FuenteRssId)
                .ForeignKey("dbo.RssUrls", t => t.RssUrl_RssUrlId)
                .Index(t => t.RssUrl_RssUrlId);
            
            CreateTable(
                "dbo.RssUrls",
                c => new
                    {
                        RssUrlId = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.RssUrlId);
            
            CreateTable(
                "dbo.TextoFijoes",
                c => new
                    {
                        TextoFijoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.TextoFijoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FuenteRsses", "RssUrl_RssUrlId", "dbo.RssUrls");
            DropIndex("dbo.FuenteRsses", new[] { "RssUrl_RssUrlId" });
            DropTable("dbo.TextoFijoes");
            DropTable("dbo.RssUrls");
            DropTable("dbo.FuenteRsses");
            DropTable("dbo.Banners");
        }
    }
}
