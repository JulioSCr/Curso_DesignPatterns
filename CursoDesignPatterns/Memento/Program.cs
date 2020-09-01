using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Historico lHistorico = new Historico();
			Contrato lContrato = new Contrato(DateTime.Now, "Julio", ETipoContrato.Novo);
			lHistorico.Adiciona(lContrato.SalvaEstado());
			Console.WriteLine(lContrato.TipoContrato);
			lContrato.Avanca();
			lHistorico.Adiciona(lContrato.SalvaEstado());
			Console.WriteLine(lContrato.TipoContrato);
			Console.ReadLine();
		}
	}
}
///É utilizado para salvar o estado do meu objeto quando eu quero guardar o histórico
