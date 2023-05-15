//FOR LOOPS
//Specifically, a for loop tends to execute the block of statements for a specified amount of iterations.
//do this for a certain amount of times rather than simply while some condition is true.

// for (initializer; condition; iterator)
//body

//Creating an initial target
int number = 55;

//   1      //2       //3     //4
for (int i = 0; i < number; i++)
{
    //5
    Console.WriteLine(i);
}

//1 - for keyword
//2 - Declaration and initialization of an iterator variable
//3 - Boolean expression comparing the new iterator to the number variable
//4 - Incrementing the iterator at the end of each loop
//5 - Dody of the loop, runs once per iteration after the boolean is evaluated as true

//exercise: prompt user for a number to count to from zero, take the input from the user and write to the console all numbers from zero to the number given
//This should be inclusive, you'll write both zero and the number they gave you to the console

Console.Write("Pick a number to have me count to:");

string? userNumber=Console.ReadLine();

int numberCount = int.Parse(userNumber);

for (int i = 0; i <= numberCount; i++)
{
    Console.WriteLine (i);
}







/*
Console.WriteLine("Pick a number you'd like me to count to.");
string? userInput = Console.ReadLine();
 int target = int.Parse(userInput); //int.Parse because changing from string to int

 for (int i = 0; i <= target; i++)
 {
    Console.WriteLine(i);
 }
 */