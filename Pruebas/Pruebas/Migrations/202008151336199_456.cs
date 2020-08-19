namespace Pruebas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _456 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Campaña", "Estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Campaña", "Estado", c => c.Boolean(nullable: false));
        }
    }
}
