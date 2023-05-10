//syntax for a ternary expression
// boolean expression ? expression if true : expression if false;

//made up of the bookean expression to be evaluated->the ?: conditional operator-> the expression to be evaluated and returned

//Module example (notice using Write instead of WriteLine)

Console.Write("Enter your age: ");
string? response = System.Console.ReadLine();
int age = int.Parse(response);

// 1             //2          //3                 //4
string output= age >= 18 ? "You can vote!" : "You're too young to vote.";

//1-Variable to hold returned value
//2-Boolean expression to be evaluated
//3-Value to be returned if 2 is true
//4-Value to be returned if 2 is false

Console.Write(output);//output is a local variable and established on line 13

if (age >= 18) 
{
    //Console.Write("You can vote!");
    output = "You can vote!";
}
else
{
    //Console.Write("You're too young to vote");
    output = "You're too young to vote";
}
Console.WriteLine(output);