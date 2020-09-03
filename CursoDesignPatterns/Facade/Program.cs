using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			string lCPF = "1234";
			EmpresaFacade lFacade = new EmpresaFacade();
			Cliente lCLiente = lFacade.BuscaCliente(lCPF);
			var lFatura = lFacade.CriaFatura(lCLiente, 100);
			lFacade.GeraCobranca(lTipo.Boleto, lFatura);
		}
	}
}
///Esse padrão de projeto, que provê uma "fachada" para os serviços disponibilizados pelos sub-sistemas, é conhecido pelo nome de Facade
