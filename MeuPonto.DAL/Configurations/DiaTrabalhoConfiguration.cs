using MeuPonto.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MeuPonto.DAL.Configurations
{
	internal class DiaTrabalhoConfiguration : EntityTypeConfiguration<DiaTrabalho>
	{
		public DiaTrabalhoConfiguration()
		{
			ToTable("DiasTrabalho");
			HasKey(c => c.Id);
			Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(c => c.Entrada).HasColumnType("DateTime").IsOptional();
			Property(c => c.IntervaloSaida).HasColumnType("DateTime").IsOptional();
			Property(c => c.IntervaloRetorno).HasColumnType("DateTime").IsOptional();
			Property(c => c.IntervaloExtraSaida).HasColumnType("DateTime").IsOptional();
			Property(c => c.IntervaloExtraRetorno).HasColumnType("DateTime").IsOptional();
			Property(c => c.Saida).HasColumnType("DateTime").IsOptional();
			Property(c => c.Observacao).HasMaxLength(300).IsOptional();
		}
	}
}
