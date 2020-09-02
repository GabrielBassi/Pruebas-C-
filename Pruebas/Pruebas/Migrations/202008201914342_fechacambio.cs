namespace Pruebas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fechacambio : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Campaña", "HoraInicio", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Campaña", "HoraFin", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Campaña", "HoraFin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Campaña", "HoraInicio", c => c.DateTime(nullable: false));
        }
    }
}
