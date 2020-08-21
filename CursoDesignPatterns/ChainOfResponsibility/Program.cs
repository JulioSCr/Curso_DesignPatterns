using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class Program
	{
		public static void Main(string[] args)
		{
			///O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem
			///executados de acordo com algum cenário em específico, e sabemos também qual o próximo cenário que deve ser validado,
			///caso o anterior não satisfaça a condição.
			///
			///Um monte de regras de negócio só que eu não posso aplicar todas elas

			///Ao receber a dependência pelo construtor, garantimos que o cliente dessas classes nunca esquecerá de passar o próximo ítem da sequência,
			///o que pode facilmente acontecer se esquecermos de colocar um valor na propriedade Proxima.

			///O possível problema com isso é que receber o próximo ítem da corrente fica ímplicito na implementação.Sempre que você criar uma nova
			///Resposta, você precisará lembrar de receber o próximo pelo construtor.Com o setter do Proxima na interface,
			///garantimos que toda implementação saberá lidar com uma próxima resposta.

			//TesteDesconto();

			TesteFormatacao();

			Console.ReadLine();
		}

		private static void TesteFormatacao()
		{
			Requisicao lRequisicaoXML = new Requisicao(EFormato.XML);
			Requisicao lRequisicaoCSV = new Requisicao(EFormato.CSV);
			Requisicao lRequisicaoPorcento = new Requisicao(EFormato.PORCENTO);

			Conta lConta = new Conta(1, 5667);

			FormatadorDeConta.Formata(lConta, lRequisicaoXML);
			FormatadorDeConta.Formata(lConta, lRequisicaoCSV);
			FormatadorDeConta.Formata(lConta, lRequisicaoPorcento);
		}

		private static void TesteDesconto()
		{
			IList<Item> lItens = new List<Item>();
			lItens.Add(new Item("Camiseta Surf", 50));
			lItens.Add(new Item("Regata Surf", 30));
			lItens.Add(new Item("Camiseta Surf", 50));
			lItens.Add(new Item("Bermuda Surf", 90));
			lItens.Add(new Item("Bermuda Surf", 90));
			lItens.Add(new Item("Bermuda", 90));
			lItens.Add(new Item("Lapis", 3000));
			lItens.Add(new Item("Caneta", 5000));
			Orcamento lOrcamento = new Orcamento(lItens);

			decimal lDesconto = CalculadorDeDescontos.Calcula(lOrcamento);
			Console.WriteLine($"Valor: {lOrcamento.Valor:N} Desconto: {lDesconto:N}");
		}
	}
}

///Você pode fazer com que o próximo ítem da corrente seja opcional
///(ou seja, o atributo outraResposta fica com null caso não haja um próximo ítem).
///E, no momento de invocar o próximo, você deve verificar se esse atributo é nulo ou não.
///Por exemplo, no exercício sobre respostas, poderíamos ter implementado da seguinte maneira:
///
///Perceba que o OutraResposta ou Proxima não está na Interface e sim no construtor,
///sendo assim forçamos aos demais devs colocar um valor de próximo para essa classe
//class RespostaEmPorcento : Resposta
//{
//	private Resposta OutraReposta { get; set; }

//	public RespostaEmPorcento(Resposta outraResposta)
//	{
//		this.OutraResposta = outraResposta;
//	}

//	public RespostaEmPorcento()
//	{
//		this.OutraResposta = null; // nao recebi a proxima!
//	}

//	public void Responde(Requisicao req, Conta conta)
//	{
//		if (req.Formato == Formato.PORCENTO)
//		{
//			Console.WriteLine(conta.Titular + '%' + conta.Saldo);
//		}
//		else if (OutraResposta != null)
//		{
//			OutraResposta.Responde(req, conta);
//		}
//		else
//		{
//			// não existe próxima na corrente, e ninguém atendeu a requisição!
//			// poderíamos não ter feito nada aqui, caso não fosse necessário!
//			throw new Exception("Formato de resposta não encontrado");
//		}
//	}
//}
