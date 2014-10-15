using MeuPonto.Models;
using MySql.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MeuPonto.DAL
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class Contexto : DbContext
	{
		public Contexto() : base("MeuPontoDB") { }
 
        public DbSet<DiaTrabalho> DiasTrabalho { get; set; }
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove();

			modelBuilder.Entity<DiaTrabalho>()
				.HasKey(c => c.Id)
				.Property(c => c.Id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
	
			modelBuilder.Entity<DiaTrabalho>()
				.ToTable("DiasTrabalho");
			
			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.Entrada)
				.HasColumnType("DateTime")
				.IsRequired();

			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.IntervaloSaida)
				.HasColumnType("DateTime")
				.IsOptional(); 
			
			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.IntervaloRetorno)
				.HasColumnType("DateTime")
				.IsOptional();

			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.IntervaloExtraSaida)
				.HasColumnType("DateTime")
				.IsOptional();
	
			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.IntervaloExtraRetorno)
				.HasColumnType("DateTime")
				.IsOptional();

			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.Saida)
				.HasColumnType("DateTime")
				.IsRequired();

			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.Observacao)
				.HasMaxLength(300)
				.IsOptional();

			base.OnModelCreating(modelBuilder);
		}
	}
}