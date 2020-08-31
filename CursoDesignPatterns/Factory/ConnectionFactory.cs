using System.Data;
using System.Data.SqlClient;

namespace Factory
{
	public class ConnectionFactory
	{
		public IDbConnection GetConnection()
		{
			IDbConnection lConexao = new SqlConnection();
			lConexao.ConnectionString = "User Id=lg;Password=syslg;Server=localhost;Database=AtonCore";
			lConexao.Open();
			return lConexao;
		}
	}
}
