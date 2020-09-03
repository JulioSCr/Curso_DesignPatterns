using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class Pedido
	{
		public Pedido(string pCliente, decimal pValor)
		{
			Cliente = pCliente;
			Valor = pValor;
			Status = EStatus.Novo;
		}

		public string Cliente { get; private set; }
		public decimal Valor { get; private set; }
		public DateTime DataFinalizacao { get; private set; }
		public EStatus Status { get; private set; }

		public void Paga()
		{
			Status = EStatus.Pago;
		}

		public void Finaliza()
		{
			Status = EStatus.Entregue;
			DataFinalizacao = DateTime.Now;
		}
	}
}
