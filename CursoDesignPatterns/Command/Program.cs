using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class Program
	{
		public static void Main(string[] args)
		{
			FilaDeTrabalho lFila = new FilaDeTrabalho();
			Pedido lPedido1 = new Pedido("Mauricio", 100);
			Pedido lPedido2 = new Pedido("Marcelo", 200);
			lFila.Adiciona(new PagaPedido(lPedido1));
			lFila.Adiciona(new PagaPedido(lPedido2));
			lFila.Adiciona(new FinalizaPedido(lPedido1));
			lFila.Processa();
			Console.ReadLine();
		}
	}
}
///Usamos ele quando temos que separar os comandos que serão executados do objeto que ele pertence. Um bom exemplo disso é o uso de filas de trabalho.

///Bem parecido com strategy, pois dependem de interfaces.
///A ideia do Command é abstrair um comando que deve ser executado,
///pois não é possível executá-lo naquele momento(pois precisamos por em uma fila ou coisa do tipo).
///Já no Strategy, a ideia é que você tenha uma estratégia(um algoritmo) para resolver um problema.
///Podemos usar Memento para restaurar estados de objetos que foram alterados por um Command.
