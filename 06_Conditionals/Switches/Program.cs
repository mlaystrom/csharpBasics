// Switch statement is made up of a collection of parts: switch keyword, value being evaluated, the case keyword, break keyword, default keyword

/*
string name = Console.ReadLine();
switch (name)
{
    case "Pete":
    //Code that runs if the variable name has the value of "Pete"
    break;
    default:
    //Code that runs for every other possible value for name
    break:
}
Line 5: declaring a switch statement that evaluates the variable that was declared
Line 7: then declare a case that checks if NAME has the value of "Pete"
Line 9: this break declares that the body of that case is done and to break out of the switch statement
**/

Console.WriteLine("How are you feeling today on a scale 1-5?");
string feelingRating = Console.ReadLine();

switch (feelingRating)
{
    case "5": //checks to see if feelingRating has the value of "5"
    Console.WriteLine("That's great to hear!");
    break; //ends the code that runs if the above case is met
    case "4":
    Console.WriteLine("Good Stuff!");
    break;
    case "3":
    Console.WriteLine("Hope things improve!");
    break;
    case "2":
    Console.WriteLine("Oh. Sorry to hear that");
    break;
    case "1":
    Console.WriteLine("Dang. We hope your day gets better.");
    break;
default: //this is only if none of the other cases are matches (acts as a final else)
Console.WriteLine("Sorry, we don't understand. Please try again.");
break;
}

Console.WriteLine("Enter a friend's name: Amber, Beth, Meghan, or Sara");
string? friendName = Console.ReadLine();
string? lowercaseFriend = friendName.ToLower();//.ToLower method added

switch (lowercaseFriend)
{
    case "amber":
    Console.WriteLine("A very dear friend that I've known the longest!");
    break;
    case "beth":
    Console.WriteLine("So easy to talk with.");
    break;
    case "meghan":
    Console.WriteLine("Loves Counting Crows as much as I do!");
    break;
    case "sara":
    Console.WriteLine("The life of the party.");
    break;
    default:
    Console.WriteLine("Sorry, I don't know this person. Please try again.");
    break;
}

//SWITCH EXPRESSIONS
//made up of: the value being evaluated, switch keyword, a body that contains the "cases" called expression arms {}, a discard pattern denoted with an underscore(_)
//requires a semicolon (;) to conclude

Console.WriteLine("How were you feeling yesterday on a scale of 1-5?");
string? ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);//because we get a string from the Console.Readline() expression we need to convert it to an integer, use the int.Parse()

string response = yesterdayRating switch
{
    1 => "Dang. We hope today is a better day.",
    2 => "Oh, sorry to hear that!",
    3 => "Hopefully things will get better this week.",
    4 => "Good stuff!",
    5 => "That's great to hear!",
   _ => "That's off the charts!"
};
Console.WriteLine(response);

//challenge is to compare these two values(feelingRating and yesterdayRating) and display how much better or worse they are feeling today than yesterday

int todayRating = int.Parse(feelingRating);
int ratingDifference = todayRating - yesterdayRating;

string output = ratingDifference switch
{
4 =>"Things are looking brighter.",
3 => "Happy to see things are better.",
2 => "A little improvement is off in the right direction!",
1 => "Some improvement!",
0 => "Looks like it about the same",
-1 => "Maybe do something that you enjoy for a few minutes?",
-2 => "Sorry to see this.",
-3 => "That's no good!",
-4 => "I wish you were having a better day.",
_ => "Not able to read this rating."
};

Console.WriteLine(output);