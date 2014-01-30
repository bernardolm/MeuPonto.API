namespace MeuPonto.DAL.Migrations
{
    using MeuPonto.Modelos;
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

			context.DiasTrabalho.AddOrUpdate(new DiaTrabalho() {
				Entrada = new DateTime(2014, 1, 1, 8, 32, 21),
				IntervaloSaida = new DateTime(2014, 1, 1, 12, 16, 21),
				IntervaloRetorno = new DateTime(2014, 1, 1, 13, 22, 21),
				Saida = new DateTime(2014, 1, 1, 17, 47, 21),
			});

			context.DiasTrabalho.AddOrUpdate(new DiaTrabalho()
			{
				Entrada = new DateTime(2014, 1, 2, 10, 19, 21),
				IntervaloSaida = new DateTime(2014, 1, 2, 14, 04, 21),
				IntervaloRetorno = new DateTime(2014, 1, 2, 15, 01, 21),
				Saida = new DateTime(2014, 1, 2, 18, 49, 21),
			});

			context.DiasTrabalho.AddOrUpdate(new DiaTrabalho()
			{
				Entrada = new DateTime(2014, 1, 3, 3, 59, 0),
				IntervaloSaida = new DateTime(2014, 1, 3, 12, 0, 0),
				IntervaloRetorno = new DateTime(2014, 1, 3, 13, 00, 00),
				Saida = new DateTime(2014, 1, 3, 23, 59, 00),
			});

			context.SaveChanges();
        }
    }
}
