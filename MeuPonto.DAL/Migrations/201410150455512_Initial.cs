namespace MeuPonto.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DiasTrabalho",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Entrada = c.DateTime(nullable: false, precision: 0),
                        IntervaloSaida = c.DateTime(precision: 0),
                        IntervaloRetorno = c.DateTime(precision: 0),
                        IntervaloExtraSaida = c.DateTime(precision: 0),
                        IntervaloExtraRetorno = c.DateTime(precision: 0),
                        Saida = c.DateTime(nullable: false, precision: 0),
                        Observacao = c.String(maxLength: 300, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("DiasTrabalho");
        }
    }
}
