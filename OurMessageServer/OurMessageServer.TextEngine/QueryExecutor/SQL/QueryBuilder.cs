using OurMessageServer.TextEngine.Models;
using System.Text;

namespace OurMessageServer.TextEngine.QueryExecutor.SQL
{
	internal class QueryBuilder
	{
		private Query _query;
		private StringBuilder _stringBuilder;

		public QueryBuilder(Query query)
		{
			_query = query;
		}

		private string getSqlQuery()
		{
			if (_stringBuilder != null) return _stringBuilder.ToString();

			_stringBuilder = new StringBuilder();
			_stringBuilder.Append("SELECT ");
			
			return _stringBuilder.ToString();
		}

		public override string ToString()
		{
			return getSqlQuery();
		}
	}
}
