using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	public class Contrato
	{
		public Contrato(DateTime pData, string pNome, ETipoContrato pTipoContrato)
		{
			Data = pData;
			Nome = pNome;
			TipoContrato = pTipoContrato;
		}

		public DateTime Data { get; private set; }
		public string Nome { get; private set; }
		public ETipoContrato TipoContrato { get; private set; }

		public void Avanca()
		{
			if (TipoContrato == ETipoContrato.Novo) TipoContrato = ETipoContrato.EmAndamento;
			else if (TipoContrato == ETipoContrato.EmAndamento) TipoContrato = ETipoContrato.Acertado;
			else if (TipoContrato == ETipoContrato.Acertado) TipoContrato = ETipoContrato.Concluido;
		}

		public Estado SalvaEstado()
		{
			return new Estado(new Contrato(Data, Nome, TipoContrato));
		}
	}
}
