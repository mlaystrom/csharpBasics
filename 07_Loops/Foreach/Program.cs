// FOR EACH
//Foreach loops execute a statement or a block of statements for each element in an instance of a IEnumerable, 
//which is basically a collection of items contained in one variable.

//ARRAYS are one of the IEnumerable types
/*
In C# an array is a data structure that can hold multiple items of the same type. 
Remember, C# is strongly typed meaning that we must declare a type first before using anything.

*/

string instructorName = "Alexis";
string[] instructors = new string [] {"Michael", "Joshua", instructorName};

//We've declared a variable with the type string as well as an array that holds strings by declaring the type string []

//Foreach Syntax
// foreach (declaredIterator in enumerableCollection)
//body

foreach (string name in instructors)
{
    Console.WriteLine(name);
}




int updatedNumber = 88;
int[] numberCollection = new int [] {123, -8, 90, updatedNumber};

foreach (int number in numberCollection)
{
 if (number > 0)
 {
    Console.WriteLine($"{number} is a positive number.");
 }
 else if (number < 0)
 {
    Console.WriteLine ($"{number} is a negative number.");
 }
 else
 {
    Console.WriteLine ($"{number} is neutral.");
 }
}