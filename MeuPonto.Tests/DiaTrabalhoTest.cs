using MeuPonto.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MeuPonto.Tests
{
	[TestFixture]
	public class DiaTrabalhoTest
    {
		private int ano = DateTime.Now.Year;
		private int mes = DateTime.Now.Month;
		private int dia = DateTime.Now.Day;
		
		[SetUp]
		public void Init()
		{
		}

		[Test]
		public void Intervalo()
		{
			Assert.AreEqual(new TimeSpan(1, 10, 0), MockValues.PeriodoTrabalho[0].Intervalo);
		}

		[Test]
		public void IntervaloExtra()
		{
			Assert.AreEqual(new TimeSpan(0, 25, 0), MockValues.PeriodoTrabalho[0].IntervaloExtra);
		}

		[Test]
		public void HorasNormaisTrabalhadas()
		{
			Assert.AreEqual(new TimeSpan(8, 31, 0), MockValues.PeriodoTrabalho[0].HorasNormaisTrabalhadas);
		}

		[Test]
		public void HorasNormaisTrabalhadas2()
		{
			Assert.AreEqual(new TimeSpan(20, 35, 0), MockValues.PeriodoTrabalho[1].HorasNormaisTrabalhadas);
		}

		[Test]
		public void HorasNormaisDevidas()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.PeriodoTrabalho[0].HorasNormaisDevidas);
		}

		[Test]
		public void HorasExtrasTrabalhadas()
		{
			Assert.AreEqual(new TimeSpan(0, 31, 0), MockValues.PeriodoTrabalho[0].HorasExtrasTrabalhadas);
		}

		[Test]
		public void HorasExtrasTrabalhadas2()
		{
			Assert.AreEqual(new TimeSpan(12, 35, 0), MockValues.PeriodoTrabalho[1].HorasExtrasTrabalhadas);
		}

		[Test]
		public void HorasNoturnasTrabalhadas()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.PeriodoTrabalho[0].HorasNoturnasTrabalhadas);
		}

		[Test]
		public void HorasNoturnasTrabalhadas2()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.PeriodoTrabalho[1].HorasNoturnasTrabalhadas);
		}

		[Test]
		public void SaidaMinima()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia, 19, 45, 00), MockValues.PeriodoTrabalho[0].SaidaMinima);
		}

		[Test]
		public void SaidaMinima2()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia+1, 12, 45, 00), MockValues.PeriodoTrabalho[1].SaidaMinima);
		}

		public static class MockValues
		{
			public static List<DiaTrabalho> PeriodoTrabalho
			{
				get
				{
					int ano = DateTime.Now.Year;
					int mes = DateTime.Now.Month;
					int dia = DateTime.Now.Day;

					return new List<DiaTrabalho>
					{
						new DiaTrabalho {
							Entrada = new System.DateTime(ano, mes, dia, 10, 10, 00),
							IntervaloSaida = new System.DateTime(ano, mes, dia, 13, 10, 00),
							IntervaloRetorno = new System.DateTime(ano, mes, dia, 14, 20, 00),
							IntervaloExtraSaida = new System.DateTime(ano, mes, dia, 18, 30, 00),
							IntervaloExtraRetorno = new System.DateTime(ano, mes, dia, 18, 55, 00),
							Saida = new System.DateTime(ano, mes, dia, 20, 16, 00)
						},
						new DiaTrabalho {
							Entrada = new System.DateTime(ano, mes, dia+1, 3, 10, 00),
							IntervaloSaida = new System.DateTime(ano, mes, dia+1, 13, 10, 00),
							IntervaloRetorno = new System.DateTime(ano, mes, dia+1, 14, 20, 00),
							IntervaloExtraSaida = new System.DateTime(ano, mes, dia+1, 18, 30, 00),
							IntervaloExtraRetorno = new System.DateTime(ano, mes, dia+1, 18, 55, 00),
							Saida = new System.DateTime(ano, mes, dia+2, 1, 15, 00)
						}
					};
				}
			}
		}
	}
}
