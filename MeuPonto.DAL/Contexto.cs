using MeuPonto.DAL.Configurations;
using MeuPonto.Models;
using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MeuPonto.DAL
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class Contexto : DbContext
	{
		public Contexto() : base("MeuPontoDB") {
			Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
		}
 
        public DbSet<DiaTrabalho> DiasTrabalho { get; set; }
		public DbSet<Periodo> Periodos { get; set; }
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			modelBuilder.Configurations.Add(new DiaTrabalhoConfiguration());
			modelBuilder.Configurations.Add(new PeriodoConfiguration());

			base.OnModelCreating(modelBuilder);
		}
	}
}