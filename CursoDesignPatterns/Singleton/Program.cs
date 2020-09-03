using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			string lCPF = "1234";
			EmpresaFacade lFacade = new EmpresaFacadeSingleton().Facade;
			Cliente lCLiente = lFacade.BuscaCliente(lCPF);
			var lFatura = lFacade.CriaFatura(lCLiente, 100);
			lFacade.GeraCobranca(lTipo.Boleto, lFatura);
		}
	}
}
///Ele faz com que só exista uma única instância da classe em todo o sistema
