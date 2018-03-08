namespace Master1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBComplete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalariatModel", "Functie", c => c.String());
            AddColumn("dbo.SalariatModel", "Vechime", c => c.Int(nullable: false));
            AddColumn("dbo.SalariatModel", "PremiiBrute", c => c.Single(nullable: false));
            AddColumn("dbo.SalariatModel", "Compensatie", c => c.Single(nullable: false));
            AddColumn("dbo.SalariatModel", "TotalBrut", c => c.Single(nullable: false));
            AddColumn("dbo.SalariatModel", "BrutImpozabil", c => c.Single(nullable: false));
            AddColumn("dbo.TaxeModel", "Impozit", c => c.Single(nullable: false));
            AddColumn("dbo.TaxeModel", "Sanatate", c => c.Single(nullable: false));
            AddColumn("dbo.TaxeModel", "Avans", c => c.Single(nullable: false));
            AddColumn("dbo.TaxeModel", "Retineri", c => c.Single(nullable: false));
            AddColumn("dbo.TaxeModel", "RestPlata", c => c.Single(nullable: false));
            AlterColumn("dbo.SalariatModel", "SalarNegociat", c => c.Single(nullable: false));
            AlterColumn("dbo.SalariatModel", "SalarRealizat", c => c.Single(nullable: false));
            AlterColumn("dbo.SalariatModel", "Spor", c => c.Single(nullable: false));
            AlterColumn("dbo.TaxeModel", "Cas", c => c.Single(nullable: false));
            AlterColumn("dbo.TaxeModel", "Somaj", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaxeModel", "Somaj", c => c.Int(nullable: false));
            AlterColumn("dbo.TaxeModel", "Cas", c => c.Int(nullable: false));
            AlterColumn("dbo.SalariatModel", "Spor", c => c.Int(nullable: false));
            AlterColumn("dbo.SalariatModel", "SalarRealizat", c => c.Int(nullable: false));
            AlterColumn("dbo.SalariatModel", "SalarNegociat", c => c.Int(nullable: false));
            DropColumn("dbo.TaxeModel", "RestPlata");
            DropColumn("dbo.TaxeModel", "Retineri");
            DropColumn("dbo.TaxeModel", "Avans");
            DropColumn("dbo.TaxeModel", "Sanatate");
            DropColumn("dbo.TaxeModel", "Impozit");
            DropColumn("dbo.SalariatModel", "BrutImpozabil");
            DropColumn("dbo.SalariatModel", "TotalBrut");
            DropColumn("dbo.SalariatModel", "Compensatie");
            DropColumn("dbo.SalariatModel", "PremiiBrute");
            DropColumn("dbo.SalariatModel", "Vechime");
            DropColumn("dbo.SalariatModel", "Functie");
        }
    }
}
