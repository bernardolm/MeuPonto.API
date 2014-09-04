using MeuPonto.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MeuPonto.DAL
{
	public class Contexto : DbContext
	{
		public Contexto() : base("MeuPontoDB") { }
 
        public DbSet<DiaTrabalho> DiasTrabalho { get; set; }
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DiaTrabalho>()
				.HasKey(c => c.Id)
				.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
	
			modelBuilder.Entity<DiaTrabalho>()
				.ToTable("DiasTrabalho");
			
			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.Entrada).HasColumnType("DateTime2").IsOptional();

			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.IntervaloSaida).HasColumnType("DateTime2").IsOptional(); 
			
			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.IntervaloRetorno).HasColumnType("DateTime2").IsOptional();

			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.IntervaloExtraSaida).HasColumnType("DateTime2").IsOptional();
	
			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.IntervaloExtraRetorno).HasColumnType("DateTime2").IsOptional();

			modelBuilder.Entity<DiaTrabalho>()
				.Property(c => c.Saida).HasColumnType("DateTime2").IsOptional();

			//modelBuilder.Entity<DiaTrabalho>()
			//	.Ignore(c => c.Intervalo);

			//modelBuilder.Entity<DiaTrabalho>()
			//	.Ignore(c => c.HorasNormaisTrabalhadas);

			//modelBuilder.Entity<DiaTrabalho>()
			//	.Ignore(c => c.IntervaloExtra);

			base.OnModelCreating(modelBuilder);
		}
	}
}
