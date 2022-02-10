using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Exercicio.Test
{
	public class GeradorDeParcelasTest
	{
		[Fact]
		public void ASomaDoValorDasParcelasDeveSerIgualAoValorDoOrcamento()
		{
			var orcamento = new Orcamento()
			{
				QtdeParcelas = 3,
				ValorTotal = 100,
				Parcelas = new List<Parcela>()
			};

			var geradorDeParcelas = new GeradorDeParcelas();

			geradorDeParcelas.GerarParcelas(orcamento);

			var totalParcelas = Math.Round(orcamento.Parcelas.Sum(p => p.ValorParcela), decimals: 2);

			Assert.Equal(3, orcamento.QtdeParcelas);
			Assert.Equal(3, orcamento.Parcelas.Count);
			Assert.Equal(orcamento.ValorTotal, totalParcelas);
		}
	}
}
