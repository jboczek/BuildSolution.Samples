namespace BuildSolution.DesignPatterns.Structural.Decorator
{
	/// <summary>
	/// Decorator class that horizontal scroll to IWindow object
	/// </summary>
	public class HorizontalScrollWindow : IWindow
	{
		private readonly IWindow _window;

		public HorizontalScrollWindow(IWindow window)
		{
			_window = window;
		}

		public string Draw()
		{
			var window = _window.Draw();
			return AddHorizontalScroll(window);
		}

		private string AddHorizontalScroll(string window)
		{
			return window + " with horizontalscroll";
		}
	}
}
