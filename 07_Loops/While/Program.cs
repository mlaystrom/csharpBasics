/**
WHILE LOOPS: This means you give the while loop a boolean to evaluate; if it's true it loops and if it's false it does not.

Format
A loop in C# is made up of a few parts:

The appropriate keyword to indicate it's a loop
A boolean expression that gets evaluated and decides if the loop needs to run
The "body," or operation, to be executed when the loop runs
 

Types of Loops
C# has four types of loops:

While
For
Foreach
Do While

Infinite Loops
Basically, anything like: while (true)   will be infinite.
You will want to make sure you're careful when working with loops as you can run into what is called an infinite loop.


*/

//Declaring a variable to use in our loop's boolean expression
int number = 0;

// While the value in number is less than or equal to 100, run the following 
while (number <= 100)
{
    //Write the value of number to the console and then increment by 5
    Console.WriteLine(number);
    number = number + 5;
}

