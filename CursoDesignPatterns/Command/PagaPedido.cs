using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class PagaPedido : IComando
	{
		public PagaPedido(Pedido pPedido)
		{
			Pedido = pPedido;
		}

		public Pedido Pedido { get; private set; }

		public void Executa()
		{
			Console.WriteLine("Pagando o pedido do cliente {0}", Pedido.Cliente);
			Pedido.Paga();
		}
	}
}
