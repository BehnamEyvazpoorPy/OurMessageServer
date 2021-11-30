using OurMessageServer.TextEngine.Models;

namespace OurMessageServer.TextEngine.Abstraction
{
	internal interface ITextProvider
	{
		public List<string> Provide(Template template);
	}
}
