using System;

namespace BuildSolution.DesignPatterns.Structural.Decorator
{
	public class Window : IWindow
	{
		public void Draw()
		{
			Console.WriteLine("Draw window");
		}
	}
}
