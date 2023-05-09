string first = "The cars we sell are";
string second = "ford, chevy, toyota.";

string space = " ";
// ways we have used combining strings

//Cocatenation (using the + operator)
string concatenatedResult = first + space + second;
Console.WriteLine(concatenatedResult);

// Composite Formatting (uses {} and indexes), we can pass in what we call arguments and the method will format it for us.

string firstName = "Marla";
string lastName = "Laystrom";

string compositeResult = string.Format("My name is {0} {1}.", firstName, lastName);
Console.WriteLine(compositeResult);

//Console.WriteLine with Composite Formatting
Console.WriteLine("The name is {1}, {0}.", firstName, lastName);

// String Interpolation ($): It takes out the indexes and allows you to simply put a variable directly into the string.
string interpolationResult =$"My name is still {firstName} {lastName}";
Console.WriteLine(interpolationResult);