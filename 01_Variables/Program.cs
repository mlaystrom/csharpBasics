// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//windows: ctrl + shift + p
//Omni retart

//declaring variables
// Javascript: let name = "value"

// c#: type name = "value";

string firstName = "Charlie";

// 1. The type is string (these matter A LOT)
// 2. The variable name is firstname
// 3.  = is the assignment operator
// 4.  The value is "Charlie"

// ctrl + . is a quick fix shortcut (a very helpful tool)

Console.WriteLine(firstName);

//dotnet build

firstName = "Scott";//changing the VALUE not the TYPE so this works
Console.WriteLine(firstName); 

//Prompt the user for input

Console.WriteLine("What is your favorite color?");

//Capture the user's input/response
//returns the value the user typed ->ReadLine()
// ? indicates it can hold a null value ->not null=null

string? color = Console.ReadLine();
Console.WriteLine("You said your favorite color is " + color);

//ReadLine()captures the input from the user
//Goes: What is your favorite color->user types answer->You said your favorite color is "what they entered"
