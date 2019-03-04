using System;
using System.Collections.Generic;

/*
1. [dotnet new console] - ** {done at beginning} ** - to build the scaffolding for a command line project.
2. [dotnet run] - executes project but also builds (compiles) first.

-- [dotnet build] - compiles project but no need to use as [dotnet run] handles it.
*/
namespace lists {
	public class Program {
		public static void Main(string[] args) {

			Console.WriteLine("Hello World!");
			Console.WriteLine();  // Blank line. Separates the output for clarity.

			// Make a list called planetList.
			List<string> planetList = new List<string>(){"Mercury", "Mars"};

			// #1 - Need to add "Jupiter" and "Saturn" to planetList.
			// Test that the original two planets are showing up.
			foreach(string planet in planetList) {
				// Prints Mercury and Mars.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// I want to add the next two planets to the list as strings.
			planetList.Add("Jupiter");
			planetList.Add("Saturn");

			// Need to run foreach again to see "Jupiter" and "Saturn" in planetList output.
			foreach(string planet in planetList) {
				// Prints all four: Mercury, Mars, Jupiter, Saturn.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// #2 - Make a new list with thr last two planets- "Uranus" and "Neptune".
			List<string> lastTwoPlanetList = new List<string>(){"Uranus", "Neptune"};

			// #3 - Combine planetList and lastTwoPlanetList using AddRange().
			// Passing lastTwoPlanetList as an argument.
			planetList.AddRange(lastTwoPlanetList);

			// Need to run foreach again to see "Uranus" and "Neptune".
			foreach(string planet in planetList) {
				// Prints all six planets in the new planetList.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// #4 - Use Insert() to add Earth, and Venus in the correct order.
			// Test run with venus first at position 2, index 1.
			planetList.Insert(1,"Venus");

			foreach(string planet in planetList) {
				// Prints all seven planets in the new planetList.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// Run with earth at position 3, index 2.
			planetList.Insert(2,"Earth");

			foreach(string planet in planetList) {
				// Prints all eight planets in the new planetList.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.
		}
	}
}
