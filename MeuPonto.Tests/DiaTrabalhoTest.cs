using NUnit.Framework;
using System;

namespace MeuPonto.Tests
{
	[TestFixture]
	public class DiaTrabalhoTest
    {
		int ano = 2014;
		int mes = 8;
		int dia = 25;
		
		[SetUp]
		public void Init()
		{
		}

		#region Dia 0

		[Test]
		public void LimiteDiurno()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia, 5, 0, 0), MockValues.DiasTrabalhoMock[0].LimiteDiurno);
		}

		[Test]
		public void LimiteNoturno()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia, 22, 0, 0), MockValues.DiasTrabalhoMock[0].LimiteNoturno);
		}
		
		[Test]
		public void Intervalo()
		{
			Assert.AreEqual(new TimeSpan(1, 10, 0), MockValues.DiasTrabalhoMock[0].Intervalo);
		}

		[Test]
		public void IntervaloExtra()
		{
			Assert.AreEqual(new TimeSpan(0, 25, 0), MockValues.DiasTrabalhoMock[0].IntervaloExtra);
		}

		[Test]
		public void HorasNormaisTrabalhadas()
		{
			Assert.AreEqual(new TimeSpan(8, 31, 0), MockValues.DiasTrabalhoMock[0].HorasNormaisTrabalhadas);
		}

		[Test]
		public void HorasNormaisDevidas()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[0].HorasNormaisDevidas);
		}

		[Test]
		public void HorasExtrasTrabalhadas()
		{
			Assert.AreEqual(new TimeSpan(0, 31, 0), MockValues.DiasTrabalhoMock[0].HorasExtrasTrabalhadas);
		}

		[Test]
		public void HorasNoturnasTrabalhadas()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[0].HorasNoturnasTrabalhadas);
		}

		[Test]
		public void SaidaMinima()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia, 19, 45, 0), MockValues.DiasTrabalhoMock[0].SaidaMinima);
		}

		#endregion Dia 0

		#region Dia 1

		[Test]
		public void LimiteDiurno1()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 1, 5, 0, 0), MockValues.DiasTrabalhoMock[1].LimiteDiurno);
		}

		[Test]
		public void LimiteNoturno1()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 1, 22, 0, 0), MockValues.DiasTrabalhoMock[1].LimiteNoturno);
		}

		[Test]
		public void Intervalo1()
		{
			Assert.AreEqual(new TimeSpan(1, 32, 0), MockValues.DiasTrabalhoMock[1].Intervalo);
		}

		[Test]
		public void IntervaloExtra1()
		{
			Assert.AreEqual(new TimeSpan(0, 33, 0), MockValues.DiasTrabalhoMock[1].IntervaloExtra);
		}

		[Test]
		public void HorasNormaisTrabalhadas1()
		{
			Assert.AreEqual(new TimeSpan(14, 55, 0), MockValues.DiasTrabalhoMock[1].HorasNormaisTrabalhadas);
		}

		[Test]
		public void HorasNormaisDevidas1()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[1].HorasNormaisDevidas);
		}

		[Test]
		public void HorasExtrasTrabalhadas1()
		{
			Assert.AreEqual(new TimeSpan(6, 55, 0), MockValues.DiasTrabalhoMock[1].HorasExtrasTrabalhadas);
		}

		[Test]
		public void HorasNoturnasTrabalhadas1()
		{
			Assert.AreEqual(new TimeSpan(5, 5, 0), MockValues.DiasTrabalhoMock[1].HorasNoturnasTrabalhadas);
		}

		[Test]
		public void SaidaMinima1()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 1, 13, 15, 0), MockValues.DiasTrabalhoMock[1].SaidaMinima);
		}

		#endregion Dia 1

		#region Dia 2

		[Test]
		public void LimiteDiurno3()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 2, 5, 0, 0), MockValues.DiasTrabalhoMock[2].LimiteDiurno);
		}

		[Test]
		public void LimiteNoturno3()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 2, 22, 0, 0), MockValues.DiasTrabalhoMock[2].LimiteNoturno);
		}

		[Test]
		public void Intervalo3()
		{
			Assert.AreEqual(new TimeSpan(1, 5, 0), MockValues.DiasTrabalhoMock[2].Intervalo);
		}

		[Test]
		public void IntervaloExtra3()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[2].IntervaloExtra);
		}

		[Test]
		public void HorasNormaisTrabalhadas3()
		{
			Assert.AreEqual(new TimeSpan(4, 10, 0), MockValues.DiasTrabalhoMock[2].HorasNormaisTrabalhadas);
		}

		[Test]
		public void HorasNormaisDevidas3()
		{
			Assert.AreEqual(new TimeSpan(3, 50, 0), MockValues.DiasTrabalhoMock[2].HorasNormaisDevidas);
		}

		[Test]
		public void HorasExtrasTrabalhadas3()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[2].HorasExtrasTrabalhadas);
		}

		[Test]
		public void HorasNoturnasTrabalhadas3()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[2].HorasNoturnasTrabalhadas);
		}

		[Test]
		public void SaidaMinima3()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 2, 18, 5, 0), MockValues.DiasTrabalhoMock[2].SaidaMinima);
		}

		#endregion Dia 2

		#region Dia 3

		[Test]
		public void LimiteDiurno4()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia+3, 5, 0, 0), MockValues.DiasTrabalhoMock[3].LimiteDiurno);
		}

		[Test]
		public void LimiteNoturno4()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 3, 22, 0, 0), MockValues.DiasTrabalhoMock[3].LimiteNoturno);
		}

		[Test]
		public void Intervalo4()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[3].Intervalo);
		}

		[Test]
		public void IntervaloExtra4()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[3].IntervaloExtra);
		}

		[Test]
		public void HorasNormaisTrabalhadas4()
		{
			Assert.AreEqual(new TimeSpan(8, 0, 0), MockValues.DiasTrabalhoMock[3].HorasNormaisTrabalhadas);
		}

		[Test]
		public void HorasNormaisDevidas4()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[3].HorasNormaisDevidas);
		}

		[Test]
		public void HorasExtrasTrabalhadas4()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[3].HorasExtrasTrabalhadas);
		}

		[Test]
		public void HorasNoturnasTrabalhadas4()
		{
			Assert.AreEqual(new TimeSpan(0, 22, 0), MockValues.DiasTrabalhoMock[3].HorasNoturnasTrabalhadas);
		}

		[Test]
		public void SaidaMinima4()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia+3, 22, 00, 0), MockValues.DiasTrabalhoMock[3].SaidaMinima);
		}

		#endregion Dia 3

		#region Dia 4

		[Test]
		public void LimiteDiurno5()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 4, 5, 0, 0), MockValues.DiasTrabalhoMock[4].LimiteDiurno);
		}

		[Test]
		public void LimiteNoturno5()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 4, 22, 0, 0), MockValues.DiasTrabalhoMock[4].LimiteNoturno);
		}

		[Test]
		public void Intervalo5()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[4].Intervalo);
		}

		[Test]
		public void IntervaloExtra5()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[4].IntervaloExtra);
		}

		[Test]
		public void HorasNormaisTrabalhadas5()
		{
			Assert.AreEqual(new TimeSpan(6, 45, 0), MockValues.DiasTrabalhoMock[4].HorasNormaisTrabalhadas);
		}

		[Test]
		public void HorasNormaisDevidas5()
		{
			Assert.AreEqual(new TimeSpan(1, 15, 0), MockValues.DiasTrabalhoMock[4].HorasNormaisDevidas);
		}

		[Test]
		public void HorasExtrasTrabalhadas5()
		{
			Assert.AreEqual(new TimeSpan(0, 0, 0), MockValues.DiasTrabalhoMock[4].HorasExtrasTrabalhadas);
		}

		[Test]
		public void HorasNoturnasTrabalhadas5()
		{
			Assert.AreEqual(new TimeSpan(4, 22, 0), MockValues.DiasTrabalhoMock[4].HorasNoturnasTrabalhadas);
		}

		[Test]
		public void SaidaMinima5()
		{
			Assert.AreEqual(new DateTime(ano, mes, dia + 4, 23, 15, 0), MockValues.DiasTrabalhoMock[4].SaidaMinima);
		}

		#endregion Dia 4
	}
}
