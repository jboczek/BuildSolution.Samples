using System;
using BuildSolution.DesignPatterns.Structural.Decorator;

namespace BuildSolution.DesignPatterns
{
	public static class Sample
	{
		public static void Decorator()
		{
			IWindow windowWithScroll = new HorizontalScrollWindow(new Window());

			Console.WriteLine(windowWithScroll.Draw());

			Console.WriteLine("------------------");

			IWindow windowWithBorderAndScroll = new WindowLogger(windowWithScroll);

			Console.WriteLine(windowWithBorderAndScroll.Draw());

			Console.ReadLine();
		}
	}
}
