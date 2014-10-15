namespace MeuPonto.DAL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiasTrabalho",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Entrada = c.DateTime(precision: 0),
                        IntervaloSaida = c.DateTime(precision: 0),
                        IntervaloRetorno = c.DateTime(precision: 0),
                        IntervaloExtraSaida = c.DateTime(precision: 0),
                        IntervaloExtraRetorno = c.DateTime(precision: 0),
                        Saida = c.DateTime(precision: 0),
                        Observacao = c.String(maxLength: 300, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Periodos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inicio = c.DateTime(precision: 0),
                        Fim = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DiasTrabalhoPeriodo",
                c => new
                    {
                        PeriodoId = c.Int(nullable: false),
                        DiasTrabalhoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PeriodoId, t.DiasTrabalhoId })
                .ForeignKey("dbo.Periodos", t => t.PeriodoId, cascadeDelete: true)
                .ForeignKey("dbo.DiasTrabalho", t => t.DiasTrabalhoId, cascadeDelete: true)
                .Index(t => t.PeriodoId)
                .Index(t => t.DiasTrabalhoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiasTrabalhoPeriodo", "DiasTrabalhoId", "dbo.DiasTrabalho");
            DropForeignKey("dbo.DiasTrabalhoPeriodo", "PeriodoId", "dbo.Periodos");
            DropIndex("dbo.DiasTrabalhoPeriodo", new[] { "DiasTrabalhoId" });
            DropIndex("dbo.DiasTrabalhoPeriodo", new[] { "PeriodoId" });
            DropTable("dbo.DiasTrabalhoPeriodo");
            DropTable("dbo.Periodos");
            DropTable("dbo.DiasTrabalho");
        }
    }
}
