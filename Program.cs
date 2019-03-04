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
			Console.WriteLine();  // Blank line. Separates the console output for clarity.

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
			// Add() places the items at the end of the list.
			planetList.Add("Jupiter");
			planetList.Add("Saturn");

			// Need to run foreach again to see "Jupiter" and "Saturn" in planetList output.
			foreach(string planet in planetList) {
				// Prints all four: Mercury, Mars, Jupiter, Saturn.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// #2 - Make a new list with the last two planets- "Uranus" and "Neptune".
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
			// Test run with venus first placed at position 2, index 1.
			planetList.Insert(1,"Venus");

			foreach(string planet in planetList) {
				// Prints all seven planets in the new planetList.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// Run with earth placed at position 3, index 2.
			planetList.Insert(2,"Earth");

			foreach(string planet in planetList) {
				// Prints all eight planets in the new planetList.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// #5 - Use Add() again to add Pluto to the end of the list.
			// Add() places items at the end of the list by default.
			planetList.Add("Pluto");

			foreach(string planet in planetList) {
				// Prints all nine planets in the new planetList.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			/*
			#6 - Slice planetList using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planetList. There are four to be added - Mercury, Venus, Earth, Mars.
			Takes two arguments:
			 - first is start position (index 0),
			 - second is count to get (4).
			*/
			List<string> rockyPlanets = planetList.GetRange(0,4);

			foreach(string planet in rockyPlanets) {
				// Prints all four planets in the new rockyPlanets.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// #7 - Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
			planetList.Remove("Pluto");

			foreach(string planet in planetList) {
				// Prints all eight planets in the new planetList.
				Console.WriteLine(planet);
			}
			Console.WriteLine();  // Blank line.

			// Practice: Random Numbers
			// Instructions:
			// #1 - Use the following code to create a list of random numbers. Each number will be between 0 and 9.
			Random random = new Random();
			// Will return a positive interger between 0 and 10.
			List<int> numbers = new List<int> {
				random.Next(10),
				random.Next(10),
				random.Next(10),
				random.Next(10),
				random.Next(10),
			};
			Console.WriteLine(numbers);

			// #2 - Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
			// Generates 25 random numbers.
			for(int index = 0; index < numbers.Count - 1; index++) {
				foreach(int number in numbers){
					Console.WriteLine(number);
				}
			}
		}
	}
}
