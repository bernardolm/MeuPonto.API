using System;
using System.ComponentModel.DataAnnotations;

namespace MeuPonto.Models
{
	public class DiaTrabalho
	{
		private readonly TimeSpan HorasATrabalharEmUmDia = new TimeSpan(8, 0, 0);
		private readonly DateTime limiteDiurno = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 5, 0, 0);
		private DateTime limiteNoturno = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 22, 0, 0);

		public int Id { get; set; }

		[DisplayFormat(DataFormatString = "{0:HH:mm}")]
		public DateTime Entrada { get; set; }

		[DisplayFormat(DataFormatString = "{0:HH:mm}")]
		[Display(Name = "Saída intervalo")]
		public DateTime IntervaloSaida { get; set; }

		[DisplayFormat(DataFormatString = "{0:HH:mm}")]
		[Display(Name = "Retorno")]
		public DateTime IntervaloRetorno { get; set; }

		[DisplayFormat(DataFormatString = "{0:HH:mm}")]
		[Display(Name = "Saída extra")]
		public DateTime IntervaloExtraSaida { get; set; }

		[DisplayFormat(DataFormatString = "{0:HH:mm}")]
		[Display(Name = "Retorno")]
		public DateTime IntervaloExtraRetorno { get; set; }

		[DisplayFormat(DataFormatString = "{0:HH:mm}")]
		[Display(Name = "Saída")]
		public DateTime Saida { get; set; }

		[Display(Name = "Observação")]
		public String Observacao { get; set; }

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		public TimeSpan Intervalo
		{
			get
			{
				return (IntervaloSaida - IntervaloRetorno).Duration();
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Intervalo extra")]
		public TimeSpan IntervaloExtra
		{
			get
			{
				return (IntervaloExtraSaida - IntervaloExtraRetorno).Duration();
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Horas normais")]
		public TimeSpan HorasNormaisTrabalhadas
		{
			get
			{
				var entrada = Entrada < limiteDiurno ? limiteDiurno : Entrada;
				var saida = Saida > limiteNoturno ? limiteDiurno : Saida;
				return (saida - entrada).Duration().Subtract(Intervalo).Subtract(IntervaloExtra);
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Horas normais que ficará devendo")]
		public TimeSpan HorasNormaisDevidas
		{
			get
			{
				if (HorasNormaisTrabalhadas - HorasATrabalharEmUmDia < new TimeSpan(0, 0, 0))
					return HorasNormaisTrabalhadas.Subtract(HorasATrabalharEmUmDia);
				else
					return new TimeSpan(0, 0, 0);
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Horas extras")]
		public TimeSpan HorasExtrasTrabalhadas
		{
			get
			{
				return HorasNormaisTrabalhadas - HorasATrabalharEmUmDia;
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Horas noturnas")]
		// 22:00 as 5:00
		public TimeSpan HorasNoturnasTrabalhadas
		{
			get
			{
				TimeSpan total = new TimeSpan();

				if (Entrada < limiteDiurno)
					total += Entrada.Subtract(limiteDiurno);

				if (Saida > limiteNoturno)
					total += limiteNoturno.Subtract(Saida);

				return total;
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Saída mínima para 8 horas")]
		public DateTime SaidaMinima
		{
			get
			{
				return Entrada.Add(HorasATrabalharEmUmDia + Intervalo + IntervaloExtra);
			}
		}
	}
}