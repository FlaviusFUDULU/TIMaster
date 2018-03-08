namespace Master1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalariatModel",
                c => new
                    {
                        NrCrt = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        Prenume = c.String(),
                        SalarNegociat = c.Int(nullable: false),
                        SalarRealizat = c.Int(nullable: false),
                        Spor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NrCrt);
            
            CreateTable(
                "dbo.TaxeModel",
                c => new
                    {
                        NrCrt = c.Int(nullable: false, identity: true),
                        Cas = c.Int(nullable: false),
                        Somaj = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NrCrt);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaxeModel");
            DropTable("dbo.SalariatModel");
        }
    }
}
