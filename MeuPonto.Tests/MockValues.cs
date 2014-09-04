using MeuPonto.Models;
using System;
using System.Collections.Generic;

namespace MeuPonto.Tests
{
	public static class MockValues
	{
		const int ano = 2014;
		const int mes = 8;
		const int dia = 25;

		public static List<DiaTrabalho> DiasTrabalhoMock
		{
			get
			{
				return new List<DiaTrabalho>
				{
					new DiaTrabalho {
						Entrada = new DateTime(ano, mes, dia, 10, 10, 0),
						IntervaloSaida = new DateTime(ano, mes, dia, 13, 10, 0),
						IntervaloRetorno = new DateTime(ano, mes, dia, 14, 20, 0),
						IntervaloExtraSaida = new DateTime(ano, mes, dia, 18, 30, 0),
						IntervaloExtraRetorno = new DateTime(ano, mes, dia, 18, 55, 0),
						Saida = new DateTime(ano, mes, dia, 20, 16, 0)
					},
					new DiaTrabalho {
						Entrada = new DateTime(ano, mes, dia+1, 3, 10, 0),
						IntervaloSaida = new DateTime(ano, mes, dia+1, 12, 48, 0),
						IntervaloRetorno = new DateTime(ano, mes, dia+1, 14, 20, 0),
						IntervaloExtraSaida = new DateTime(ano, mes, dia+1, 18, 30, 0),
						IntervaloExtraRetorno = new DateTime(ano, mes, dia+1, 19, 3, 0),
						Saida = new DateTime(ano, mes, dia+2, 1, 15, 0)
					},
					new DiaTrabalho {
						Entrada = new DateTime(ano, mes, dia+2, 9, 0, 0),
						IntervaloSaida = new DateTime(ano, mes, dia+2, 12, 0, 0),
						IntervaloRetorno = new DateTime(ano, mes, dia+2, 13, 5, 0),
						Saida = new DateTime(ano, mes, dia+2, 14, 15, 0)
					},
					new DiaTrabalho {
						Entrada = new DateTime(ano, mes, dia+3, 14, 0, 0),
						Saida = new DateTime(ano, mes, dia+3, 22, 22, 0)
					},
					new DiaTrabalho {
						Entrada = new DateTime(ano, mes, dia+4, 15, 15, 0),
						Saida = new DateTime(ano, mes, dia+5, 2, 22, 0)
					}
				};
			}
		}

		public static Periodo PeriodoMock
		{
			get
			{
				return new Periodo
				{
					Inicio = new DateTime(ano, mes, dia, 0, 0, 0),
					Fim = new DateTime(ano, mes, dia+5, 0, 0, 0),
					Dias = DiasTrabalhoMock
				};
			}
		}
	}
}
