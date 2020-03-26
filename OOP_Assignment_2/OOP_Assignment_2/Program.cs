using System;
using System.IO;

namespace OOP_Assignment_2
{
    class Program
    {
        static void Main(string[] args) // This class will check different files and compare whether they are similar or not
		{
			Console.WriteLine("Please input the file location(s) and file type(s) that you would like to compare"); // This line asks the user what files they would like to compare
			string files = Console.ReadLine(); // This reads the input from the user and adds it into a string called files
			string[] filesArr = files.Split(" "); // This array is used to differentiate between the files by splitting the input after a space
			string[] filea = File.ReadAllLines(filesArr[0]); // Checks the text before the space and then adds this file to the string filea
			string[] fileb = File.ReadAllLines(filesArr[1]);

			if (filea == fileb) // Checks whether the text in filea matches the text in fileb
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("The Files you have selected match");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else // This is used if the texts do not match
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("The Files you have selected do not match");
				Console.ForegroundColor = ConsoleColor.White;
			}



		}
    }
}
