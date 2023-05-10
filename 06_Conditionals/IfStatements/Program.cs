bool isRaining = true;
bool isGoingOutside = true;

/**
If Statement Syntax
if (true/false value or expression)
{
    curly braces on a new line

    Body of code to be executed if the condition is true
}

*/

if (isRaining)
{
    Console.WriteLine("It is Raining");

}

// If is raining AND we are going outside
if (isRaining && isGoingOutside)
{
    Console.WriteLine("Better bring an umbrella.");
}

// Is not raining OR we are not going outside

if (!isRaining || !isGoingOutside)
{
    Console.WriteLine("I do not need an umbrella.");
}

// Exclusively raining or we are going outside

if (isRaining ^ isGoingOutside)
{
    Console.WriteLine ("I will only go outside if it is not raining.");
}

// IF ELSE: If it is not raining cut the grass, if it is raining don't cut the grass
if (isRaining)
{

}
if (!isRaining)
{

}

//IF ELSE PROPER WAY

if (!isRaining)
{
    Console.WriteLine("I will go cut the grass.");
}
else 
{
    Console.WriteLine (" I will not cut the grass.");
}

//if else based on one condition

if (isGoingOutside)
{
    Console.WriteLine("Make sure to dress for the weather!");
}
else 
{
    Console.WriteLine("Sounds like a sweats kind of day.");
}

Console.WriteLine("How are you feeling on a scale of 1-5?");

//declaring a variable with a Console.ReadLine();
string feelingRating = Console.ReadLine();

/**
Dang. We hope your day gets better!
Oh. Sorry to hear that.
Hope things improve!
Good stuff!
That's great to hear!
*/




if (feelingRating =="1")
{
    Console.WriteLine("Dang. We hope your day gets better!");
}
else if (feelingRating == "2")
{
    Console.WriteLine ("Oh. Sorry to hear that");
}
else if ( feelingRating == "3")
{
    Console.WriteLine("Hope things improve!");
}
else if (feelingRating == "4")
{
    Console.WriteLine("Good Stuff!");
}
else if (feelingRating == "5")
{
    Console.WriteLine("That's great to hear!");
}
else{
    Console.WriteLine("🤔");
}

