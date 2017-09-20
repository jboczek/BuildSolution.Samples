using System;

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

		public void Draw()
		{
			_window.Draw();
			DrawHorizontalScroll();
		}

		private void DrawHorizontalScroll()
		{
			Console.WriteLine("Draw horizontal scroll");
		}
	}
}
