using OurMessageServer.TextEngine.Models;

namespace OurMessageServer.TextEngine.Abstraction
{
	internal interface IQueryExecutor<TResult>
	{
		public TResult Execute(Query query);
	}
}
