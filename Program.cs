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
			Console.WriteLine();  // Blank line.

			// Make a list called planetList.
			List<string> planetList = new List<string>(){"Mercury", "Mars"};

			// #1 - Need to add "Jupiter" and "Saturn" to planetList.
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
			// #2 - Make a new list with last two planets.
			List<string> lastTwoPlanetList = new List<string>(){"Saturn", "Uranus"};

			// #3 - Combine planetList and lastTwoPlanetList.
		}
	}
}
