using System;
using System.ComponentModel.DataAnnotations;

namespace MeuPonto.Models
{
	public class DiaTrabalho
	{
		private readonly TimeSpan HorasATrabalharEmUmDia = new TimeSpan(8, 0, 0);
		
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

		[DisplayFormat(DataFormatString = "{0:HH:mm}")]
		[Display(Name = "Limite diurno")]
		public DateTime LimiteDiurno
		{
			get
			{
				if (this.Entrada == DateTime.MinValue)
					return new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 5, 0, 0);
				else
					return new DateTime(Entrada.Year, Entrada.Month, Entrada.Day, 5, 0, 0);
			}
		}

		[DisplayFormat(DataFormatString = "{0:HH:mm}")]
		[Display(Name = "Limite noturno")]
		public DateTime LimiteNoturno
		{
			get
			{
				if (this.Entrada == DateTime.MinValue)
					return new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 22, 0, 0);
				else
					return new DateTime(Entrada.Year, Entrada.Month, Entrada.Day, 22, 0, 0);
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		public TimeSpan Intervalo
		{
			get
			{
				return IntervaloSaida.Subtract(IntervaloRetorno).Duration();
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Intervalo extra")]
		public TimeSpan IntervaloExtra
		{
			get
			{
				return IntervaloExtraSaida.Subtract(IntervaloExtraRetorno).Duration();
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Horas não noturnas trabalhadas no dio")]
		public TimeSpan HorasNormaisTrabalhadas
		{
			get
			{
				var entrada = Entrada < LimiteDiurno ? LimiteDiurno : Entrada;
				var saida = Saida > LimiteNoturno ? LimiteNoturno : Saida;
				return saida.Subtract(entrada).Subtract(Intervalo).Subtract(IntervaloExtra);
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Horas normais que ficará devendo")]
		public TimeSpan HorasNormaisDevidas
		{
			get
			{
				var entrada = Entrada < LimiteDiurno ? LimiteDiurno : Entrada;
				var saida = Saida > LimiteNoturno ? LimiteNoturno : Saida;
				var horasNormaisTrabalhadas = saida.Subtract(entrada).Subtract(Intervalo).Subtract(IntervaloExtra);

				if (horasNormaisTrabalhadas.Subtract(HorasATrabalharEmUmDia) < new TimeSpan(0, 0, 0))
					return horasNormaisTrabalhadas.Subtract(HorasATrabalharEmUmDia).Duration();
				else
					return new TimeSpan(0, 0, 0);
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Horas não noturnas trabalhadas além da jornada diária normal")]
		public TimeSpan HorasExtrasTrabalhadas
		{
			get
			{
				var entrada = Entrada < LimiteDiurno ? LimiteDiurno : Entrada;
				var saida = Saida > LimiteNoturno ? LimiteNoturno : Saida;
				var horasNormaisTrabalhadas = saida.Subtract(entrada).Subtract(Intervalo).Subtract(IntervaloExtra);

				if (horasNormaisTrabalhadas.Subtract(HorasATrabalharEmUmDia) > new TimeSpan(0, 0, 0))
					return horasNormaisTrabalhadas.Subtract(HorasATrabalharEmUmDia);
				else
					return new TimeSpan(0, 0, 0);
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Horas noturnas")]
		// 22:00 as 5:00
		public TimeSpan HorasNoturnasTrabalhadas
		{
			get
			{
				TimeSpan total = new TimeSpan(0, 0, 0);

				if (Entrada < LimiteDiurno)
					total += LimiteDiurno.Subtract(Entrada);

				if (Saida > LimiteNoturno)
					total += Saida.Subtract(LimiteNoturno);

				return total;
			}
		}

		[DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
		[Display(Name = "Saída mínima para 8 horas")]
		public DateTime SaidaMinima
		{
			get
			{
				return Entrada.Add(HorasATrabalharEmUmDia).Add(Intervalo).Add(IntervaloExtra);
			}
		}
	}
}