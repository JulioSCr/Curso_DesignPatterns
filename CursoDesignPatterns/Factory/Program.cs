using System.Data;

namespace Factory
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IDbConnection lConexao = new ConnectionFactory().GetConnection();
			IDbCommand lComando = lConexao.CreateCommand();
			lComando.CommandText = "select * from glo.tbPessoa";
		}
	}
}
///Isola a criação de projetos complicados como o padrão Builder, porém a implementação desses objetos não varia tanto como o Builder.
