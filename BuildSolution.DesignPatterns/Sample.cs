using System;
using BuildSolution.DesignPatterns.Structural.Decorator;

namespace BuildSolution.DesignPatterns
{
	public static class Sample
	{
		public static void Decorator()
		{
			IWindow windowWithScroll = new HorizontalScrollWindow(new Window());

			windowWithScroll.Draw();

			Console.WriteLine("------------------");

			IWindow windowWithBorderAndScroll = new WindowLogger(windowWithScroll);

			windowWithBorderAndScroll.Draw();

			Console.ReadLine();
		}
	}
}
