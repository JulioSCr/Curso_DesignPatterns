using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	public class Cliente
	{
		public Cliente() { }

		public Cliente(string pNome, string pEndereco, DateTime pDataNascimento)
		{
			Nome = pNome;
			Endereco = pEndereco;
			DataNascimento = pDataNascimento;
		}

		public string Nome { get; set; }
		public string Endereco { get; set; }
		public DateTime DataNascimento { get; set; }
	}
}
