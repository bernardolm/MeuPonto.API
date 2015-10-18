namespace MeuPonto.DAL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.dia_trabalho",
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
                "dbo.periodo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inicio = c.DateTime(precision: 0),
                        Fim = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.dia_trabalho_periodo",
                c => new
                    {
                        PeriodoId = c.Int(nullable: false),
                        DiasTrabalhoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PeriodoId, t.DiasTrabalhoId })
                .ForeignKey("dbo.periodo", t => t.PeriodoId, cascadeDelete: true)
				.ForeignKey("dbo.dia_trabalho", t => t.DiasTrabalhoId, cascadeDelete: true)
                .Index(t => t.PeriodoId)
                .Index(t => t.DiasTrabalhoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.dia_trabalho_periodo", "dia_trabalho_id", "dbo.dia_trabalho");
            DropForeignKey("dbo.dia_trabalho_periodo", "periodo_id", "dbo.periodo");
            DropIndex("dbo.dia_trabalho_periodo", new[] { "dia_trabalho_id" });
            DropIndex("dbo.dia_trabalho_periodo", new[] { "periodo_id" });
            DropTable("dbo.dia_trabalho_periodo");
            DropTable("dbo.periodo");
            DropTable("dbo.dia_trabalho");
        }
    }
}
