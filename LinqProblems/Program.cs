using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			////Problem 1
			//var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
			//var lispWords = words.Where(w => w.Contains("th"));
			//foreach (var word in lispWords)
			//{
			//	Console.WriteLine(word);
			//}

			//Console.ReadLine();
			//------------------------------------------------------


			////Problem 2
			//var names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
			//IEnumerable<string> distinctNames = names.Distinct();
			//foreach (var name in distinctNames)
			//{
			//	Console.WriteLine(name);
			//}

			//Console.ReadLine();
			//------------------------------------------------------



			////Problem 3
			//Func<string, double> stringToDoubleDelegate; //Create a Func T delegate as a placeholder for various methods that take a string and turn it into a double (This is extra and not needed for this problem, just added for practice)

			//var globalAverageList = new List<double>(); //This will be the global list of averages
			//var classGrades = new List<string>()
			//{
			//	"80,100,92,89,65",
			//	"93,81,78,84,69",
			//	"73,88,83,99,64",
			//	"98,100,66,74,55"
			//};

			//var testGrades = new List<string>() //**TESTING CODE**
			//{
			//	"90,800,92,69,45",
			//	"83,71,74,48,96",
			//	"37,88,38,99,46",
			//	"89,50,66,47,55"
			//};

			//GetGlobalAverage(classGrades); //This method runs the code to find an average from a list of averages; Must pass in a list of strings to run it

			//void GetGlobalAverage(List<string> list)
			//{
			//	stringToDoubleDelegate = SplitListRemoveMinFindAVG;
			//	foreach (var stringList in list) //This loop goes through each string in classGrade List, then I pass that string as a parameter for the Func<string, double> delegate
			//	{
			//		double result = stringToDoubleDelegate(stringList);
			//		globalAverageList.Add(result);
			//	}
			//	double globalGradeAverage = globalAverageList.Average();
			//	Console.WriteLine(globalGradeAverage);
			//	Console.ReadLine();
			//}

			//double SplitListRemoveMinFindAVG(string grades)
			//{
			//	//1. Split by comma
			//	//2. Add to new list, then parse each value into an int
			//	//3. Go through new list finding the lowest int, remove it
			//	//4. Average the remaining integers, return that double

			//	string[] arrayGrades = new string[grades.Length];
			//	var listOfGrades = new List<int>();
			//	arrayGrades = grades.Split(','); //split the string by the comma,
			//									 //run a for loop that goes through all the 
			//	for (int i = 0; i < arrayGrades.Length; i++)
			//	{
			//		listOfGrades.Add(int.Parse(arrayGrades[i]));
			//	}
			//	var minNumber = listOfGrades.Min();
			//	//Console.WriteLine(minNumber);

			//	for (int i = 0; i < listOfGrades.Count; i++)
			//	{
			//		if (listOfGrades[i] == minNumber)
			//		{
			//			listOfGrades.RemoveAt(i);
			//		}
			//	}

			//	double result = listOfGrades.Average();
			//	return result;
			//}
		//------------------------------------------------------



		//Problem 4

		//Create a method to take in a string
		//

		
		string ConvertStringToList(string value)
			{
				var stringList = new List<string>();
				var distinctNumbers = new List<int>();
				var letterFrequency = new List<int>();
				var result = "";
				for (int i = 0; i < value.Length; i++)
				{
					stringList.Add(value[i].ToString());
					//Console.WriteLine(stringList[i]);
				}

				List<string> distinctLetters = stringList.OrderBy((x) => { return x; }).Distinct().ToList(); //This list will but the characters in the list in alphabetical order and filter out the duplicates

				foreach (var item in distinctLetters) //**TEST CODE
				{
					//Console.WriteLine(item);
				}

				foreach (var letter in distinctLetters) //This foreach loop goes through the distinctLetters list and compares each character of the distinctLetters to the original StringList, then goes and find the frequency of each character in the stringList
				{
					letterFrequency.Add(stringList.OrderBy((x) => { return x; }).Where(x => x.Equals(letter)).Count());
					//Console.WriteLine(letterFrequency);
				}

				for (int i = 0; i < distinctLetters.Count; i++) //This for loop is used to output a string that concatenates together the chars of distinctLetters and letterFrequency lists
				{
					result += distinctLetters[i];
					result += letterFrequency[i];
				}
				Console.WriteLine(result);
				return result;

			}
			ConvertStringToList("Terrill");
			Console.ReadLine();

			
		}
	}
}
