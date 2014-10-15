using MeuPonto.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MeuPonto.DAL.Configurations
{
	internal class PeriodoConfiguration : EntityTypeConfiguration<Periodo>
	{
		public PeriodoConfiguration()
        {
			ToTable("Periodos");
            HasKey(c => c.Id);
			Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(c => c.Inicio).HasColumnType("DateTime").IsOptional();
			Property(c => c.Fim).HasColumnType("DateTime").IsOptional();
			HasMany(c => c.Dias).WithMany()
				.Map(m =>
				{
					m.MapLeftKey("PeriodoId");
					m.MapRightKey("DiasTrabalhoId");
					m.ToTable("DiasTrabalhoPeriodo");
				});
        }
	}
}