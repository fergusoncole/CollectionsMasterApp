using System;
using System.Collections.Generic;
using CollectionsMasterConsoleUI; 
//TODO: Follow the steps provided in the comments under each region.
//Make the console formatted to display each section well
//Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

#region Arrays
//TODO: Create an integer Array of size 50
int[] numbers = new int[50];

//TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
Methods.Populater(numbers);

//TODO: Print the first number of the array
Console.WriteLine($"\nIndex 0: {numbers[0]} \n- - - - - - - - - - - - - -");
//TODO: Print the last number of the array            
Console.WriteLine($"Last index: {numbers[numbers.Length - 1]} \n - - - - - - -");

Console.WriteLine("All Numbers Original");
//UNCOMMENT this method to print out your numbers from arrays or lists
Methods.NumberPrinter(numbers);
Console.WriteLine("-------------------");

//TODO: Reverse the contents of the array and then print the array out to the console.
//Try for 2 different ways
Array.Reverse(numbers);

Console.WriteLine("All Numbers Reversed:");
Methods.NumberPrinter(numbers);

Console.WriteLine("All Numbers Reversed:");
Methods.NumberPrinter(numbers);

Console.WriteLine("---------REVERSE CUSTOM------------");
Methods.ReverseArray(numbers);
Methods.NumberPrinter(numbers);

Console.WriteLine("-------------------");

//TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
Console.WriteLine("Multiple of three = 0: ");

Methods.ThreeKiller(numbers);
Methods.NumberPrinter(numbers);
Console.WriteLine();
Console.WriteLine("-------------------");

//TODO: Sort the array in order now
/*      Hint: Array.____()      */
Console.WriteLine("Sorted numbers:");
Array.Sort(numbers);
Methods.NumberPrinter(numbers);
Console.WriteLine();
Console.WriteLine("----------------------");


Console.WriteLine("\n************End Arrays*************** \n");
#endregion

#region Lists
Console.WriteLine("************Start Lists**************");

/*   Set Up   */
//TODO: Create an integer List

var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//TODO: Print the capacity of the list to the console);

Console.WriteLine($"List starting capacity: {list.Capacity}");
//TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
Methods.Populater(list);
Methods.NumberPrinter(list);

//TODO: Print the new capacity
Console.WriteLine($"List starting capacity: {list.Capacity}");

Console.WriteLine("---------------------");

//TODO: Create a method that prints if a user number is present in the list
//Remember: What if the user types "abc" accident your app should handle that!
Console.WriteLine("What number will you search for in the number list?");
int searchNumber = int.Parse(Console.ReadLine());
Methods.NumberChecker(list, searchNumber);
Console.WriteLine("-------------------");

Console.WriteLine("All Numbers:");
//UNCOMMENT this method to print out your numbers from arrays or lists
Methods.NumberPrinter(list);
Console.WriteLine("-------------------");


//TODO: Create a method that will remove all odd numbers from the list then print results
Console.WriteLine("Evens Only!!");
Methods.OddKiller(list);
Methods.NumberPrinter(list);
Console.WriteLine("------------------");

//TODO: Sort the list then print results
Console.WriteLine("Sorted Evens!!");
list.Sort();
Methods.NumberPrinter(list);

Console.WriteLine("------------------");

//TODO: Convert the list to an array and store that into a variable
var arrayFromList = list.ToArray();

//TODO: Clear the list
list.Clear();
#endregion

