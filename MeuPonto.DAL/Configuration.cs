namespace MeuPonto.DAL
{
	using MeuPonto.Models;
	using MySql.Data.Entity;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
			SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
        }

        protected override void Seed(Contexto context)
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

			context.DiasTrabalho.AddRange(MockValues.DiasTrabalhoMock.ToArray());

			context.Periodos.AddRange(MockValues.PeriodosMock.ToArray());

			context.SaveChanges();
        }
    }
}