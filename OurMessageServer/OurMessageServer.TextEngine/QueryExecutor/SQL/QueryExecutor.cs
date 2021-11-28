
using OurMessageServer.TextEngine.Abstraction;
using OurMessageServer.TextEngine.Models;
using System.Data.SqlClient;

namespace OurMessageServer.TextEngine.QueryExecutor.SQL
{
	internal class QueryExecutor : IQueryExecutor<QueryResult>
	{
		private SqlConnection _connection;

		public QueryExecutor(SqlConnection connection)
		{
			_connection = connection;
		}
		public QueryResult Execute(Query query)
		{
			throw new NotImplementedException();
		}

	}
}
