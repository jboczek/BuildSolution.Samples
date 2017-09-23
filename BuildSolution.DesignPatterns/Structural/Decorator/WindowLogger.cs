using System;

namespace BuildSolution.DesignPatterns.Structural.Decorator
{
	/// <summary>
	/// Decorator class adds logging logic to IWindow element
	/// </summary>
	public class WindowLogger : IWindow
	{
		private readonly IWindow _window;

		public WindowLogger(IWindow window)
		{
			_window = window;
		}
		public string Draw()
		{
			ConsoleLogBeforeDraw();

			return _window.Draw();
		}

		private void ConsoleLogBeforeDraw()
		{
			Console.WriteLine("Log: Start drawing");
		}
	}
}
