using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Test
{
	internal class GeradorDeParcelas
	{
		public void GerarParcelas(Orcamento orcamento)
		{

			decimal ValorDeCadaParcela = (orcamento.ValorTotal / orcamento.QtdeParcelas);
			List<Parcela> ListaParcelas = new List<Parcela>();

			decimal a, b;
			a = 1; b = 2;

			for (int i = 0; i < orcamento.QtdeParcelas; i++)
			{
				Parcela parcela = new Parcela();
				parcela.ValorParcela = ValorDeCadaParcela;
				ListaParcelas.Add(parcela);

				if (orcamento.ValorTotal % orcamento.QtdeParcelas >= 1 && i == 0)
				{
					parcela.ValorParcela += a;
				}
				else if (orcamento.ValorTotal % orcamento.QtdeParcelas >= 2 && i == 0)
				{
					parcela.ValorParcela += b;
				}
			}
			orcamento.Parcelas = ListaParcelas;
		}
	}
}
