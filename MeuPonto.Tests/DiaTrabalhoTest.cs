using MeuPonto.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace MeuPonto.Tests
{
	[TestFixture]
	public class DiaTrabalhoTest
    {
		[SetUp]
		public void Init()
		{
		}

		[Test]
		public void IntervaloTest()
		{
		}

		public static class MockValues
		{
			public static List<DiaTrabalho> UserList
			{
				get
				{
					return new List<DiaTrabalho>
					{
						new DiaTrabalho {
							Entrada = new System.DateTime(2014, 08, 20, 10, 10, 00),
							IntervaloSaida = new System.DateTime(2014, 08, 20, 13, 10, 00),
							IntervaloRetorno = new System.DateTime(2014, 08, 20, 14, 20, 00),
							IntervaloExtraSaida = new System.DateTime(2014, 08, 20, 18, 30, 00),
							IntervaloExtraRetorno = new System.DateTime(2014, 08, 20, 18, 55, 00),
							Saida = new System.DateTime(2014, 08, 20, 20, 16, 00)
						},
						new DiaTrabalho {
							Entrada = new System.DateTime(2014, 08, 21, 10, 10, 00),
							IntervaloSaida = new System.DateTime(2014, 08, 21, 13, 10, 00),
							IntervaloRetorno = new System.DateTime(2014, 08, 21, 14, 20, 00),
							IntervaloExtraSaida = new System.DateTime(2014, 08, 21, 18, 30, 00),
							IntervaloExtraRetorno = new System.DateTime(2014, 08, 21, 18, 55, 00),
							Saida = new System.DateTime(2014, 08, 21, 20, 16, 00)
						}
					};
				}
			}
		}
	}
}
