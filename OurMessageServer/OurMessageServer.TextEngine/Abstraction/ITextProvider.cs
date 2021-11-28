namespace OurMessageServer.TextEngine.Abstraction
{
	public interface ITextProvider
	{
		public List<string> Provide(string templateName);
	}
}
