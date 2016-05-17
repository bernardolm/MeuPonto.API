using MeuPonto.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MeuPonto.DAL.Configurations
{
	internal class DiaTrabalhoConfiguration : EntityTypeConfiguration<DiaTrabalho>
	{
		public DiaTrabalhoConfiguration()
        {
			ToTable("dia_trabalho");
            HasKey(c => c.Id);
			Property(c => c.Id)
				.HasColumnName("dia_trabalho_id")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(c => c.Entrada)
				.HasColumnName("entrada")
				.HasColumnType("DateTime")
				.IsOptional();
			Property(c => c.IntervaloSaida)
				.HasColumnName("intervalo_saida")
				.HasColumnType("DateTime")
				.IsOptional();
			Property(c => c.IntervaloRetorno)
				.HasColumnName("intervalo_retorno")
				.HasColumnType("DateTime")
				.IsOptional();
			Property(c => c.IntervaloExtraSaida)
				.HasColumnName("intervalo_extra_saida")
				.HasColumnType("DateTime")
				.IsOptional();
			Property(c => c.IntervaloExtraRetorno)
				.HasColumnName("intervalo_extra_retorno")
				.HasColumnType("DateTime")
				.IsOptional();
			Property(c => c.Saida)
				.HasColumnName("saida")
				.HasColumnType("DateTime")
				.IsOptional();
			Property(c => c.Observacao)
				.HasColumnName("observacao")
				.HasMaxLength(300)
				.IsOptional();
        }
	}
}
