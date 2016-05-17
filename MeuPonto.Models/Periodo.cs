using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeuPonto.Models
{
	public class Periodo
	{
		public int Id { get; set; }

		[Display(Name = "Início do período")]
		public DateTime Inicio { get; set; }

		[Display(Name = "Fim do período")]
		public DateTime Fim { get; set; }

		[Display(Name = "Registro dos dias de trabalho")]
		public List<DiaTrabalho> Dias { get; set; }

		[Display(Name = "Total de horas não noturnas trabalhas no período")]
		public TimeSpan TotalHorasNormaisTrabalhadas
		{
			get
			{
				var total = new TimeSpan(0, 0, 0);
				foreach (var item in this.Dias)
					total = total.Add(item.HorasNormaisTrabalhadas);
				return total;
			}
		}

		[Display(Name = "Total de horas noturnas trabalhas no período")]
		public TimeSpan TotalHorasNoturnasTrabalhadas
		{
			get
			{
				var total = new TimeSpan(0, 0, 0);
				foreach (var item in this.Dias)
					total = total.Add(item.HorasNoturnasTrabalhadas);
				return total;
			}
		}
	}
}
