using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	class FinalizaPedido : IComando
	{
		public FinalizaPedido(Pedido pPedido)
		{
			Pedido = pPedido;
		}

		public Pedido Pedido { get; private set; }

		public void Executa()
		{
			Console.WriteLine("Finalizando o pedido do cliente {0}", Pedido.Cliente);
			Pedido.Finaliza();
		}
	}
}
