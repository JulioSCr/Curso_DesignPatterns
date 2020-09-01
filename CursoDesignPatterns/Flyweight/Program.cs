using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	public class Program
	{
		public static void Main(string[] args)
		{
			NotasMusicais lNota = new NotasMusicais();
			IList<INota> lMusica = new List<INota>()
			{
				lNota.Pega("do"),
				lNota.Pega("re"),
				lNota.Pega("mi"),
				lNota.Pega("fa"),
				lNota.Pega("fa"),
				lNota.Pega("fa")
			};
			Piano lPiano = new Piano();
			lPiano.Toca(lMusica);
			Console.ReadLine();
		}
	}
}
///Todas as notas são criadas só uma vez e reutilizadas na aplicação

///Um Flyweight serve para quando temos muitas instâncias do mesmo objeto andando pelo sistema,
///e precisamos economizar. Para tal, o Flyweight faz uso de uma fábrica modificada, que guarda essas instâncias.