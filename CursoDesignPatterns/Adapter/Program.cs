using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Cliente lCliente = new Cliente("Julio", "Rua Leopardo", DateTime.Now);
			string lXml = new GeradorXml().GeraXml(lCliente);
			Console.WriteLine(lXml);
			Console.ReadLine();
		}
	}
}
///Utilizamos o adapter quando queremos adaptar o código de um sistema legado ou de uma biblioteca para que ele trabalhe corretamente
///com o sistema orientado a objetos que está sendo desenvolvido.
