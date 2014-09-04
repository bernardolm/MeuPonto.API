namespace MeuPonto.DAL.Migrations
{
    using MeuPonto.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MeuPonto.DAL.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MeuPonto.DAL.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

			int ano = 2014;
			int mes = 8;
			int dia = 25;

			context.DiasTrabalho.AddOrUpdate(new DiaTrabalho() {
				Entrada = new DateTime(ano, mes, dia, 10, 10, 0),
				IntervaloSaida = new DateTime(ano, mes, dia, 13, 10, 0),
				IntervaloRetorno = new DateTime(ano, mes, dia, 14, 20, 0),
				IntervaloExtraSaida = new DateTime(ano, mes, dia, 18, 30, 0),
				IntervaloExtraRetorno = new DateTime(ano, mes, dia, 18, 55, 0),
				Saida = new DateTime(ano, mes, dia, 20, 16, 0)
			});

			context.DiasTrabalho.AddOrUpdate(new DiaTrabalho()
			{
				Entrada = new DateTime(ano, mes, dia + 1, 3, 10, 0),
				IntervaloSaida = new DateTime(ano, mes, dia + 1, 12, 48, 0),
				IntervaloRetorno = new DateTime(ano, mes, dia + 1, 14, 20, 0),
				IntervaloExtraSaida = new DateTime(ano, mes, dia + 1, 18, 30, 0),
				IntervaloExtraRetorno = new DateTime(ano, mes, dia + 1, 19, 3, 0),
				Saida = new DateTime(ano, mes, dia + 2, 1, 15, 0)
			});

			context.DiasTrabalho.AddOrUpdate(new DiaTrabalho()
			{
				Entrada = new DateTime(ano, mes, dia + 2, 9, 0, 0),
				IntervaloSaida = new DateTime(ano, mes, dia + 2, 12, 0, 0),
				IntervaloRetorno = new DateTime(ano, mes, dia + 2, 13, 5, 0),
				Saida = new DateTime(ano, mes, dia + 2, 14, 15, 0)
			});

			context.DiasTrabalho.AddOrUpdate(new DiaTrabalho()
			{
				Entrada = new DateTime(ano, mes, dia + 3, 14, 0, 0),
				Saida = new DateTime(ano, mes, dia + 3, 22, 22, 0)
			});

			context.DiasTrabalho.AddOrUpdate(new DiaTrabalho()
			{
				Entrada = new DateTime(ano, mes, dia + 4, 15, 15, 0),
				Saida = new DateTime(ano, mes, dia + 5, 2, 22, 0)
			});

			context.SaveChanges();
        }
    }
}
