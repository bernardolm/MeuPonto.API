using MeuPonto.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MeuPonto.DAL.Configurations
{
	internal class PeriodoConfiguration : EntityTypeConfiguration<Periodo>
	{
		public PeriodoConfiguration()
        {
			ToTable("periodo");
            HasKey(c => c.Id);
			Property(c => c.Id)
				.HasColumnName("periodo_id")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(c => c.Inicio)
				.HasColumnName("inicio")
				.HasColumnType("DateTime")
				.IsOptional();
			Property(c => c.Fim)
				.HasColumnName("fim")
				.HasColumnType("DateTime")
				.IsOptional();
			HasMany(c => c.Dias)
				.WithMany()
				.Map(m =>
				{
					m.MapLeftKey("periodo_id");
					m.MapRightKey("dia_trabalho_id");
					m.ToTable("dias_trabalho_periodo");
				});
        }
	}
}