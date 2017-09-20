using System;
using BuildSolution.DesignPatterns;

namespace BuildSolutionSample
{
	class Program
	{
		static void Main(string[] args)
		{
			var designPatternToTry = DesignPattern.Decorator;

			switch (designPatternToTry)
			{
				case DesignPattern.Decorator:
					Sample.Decorator();
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}