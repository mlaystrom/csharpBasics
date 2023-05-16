// bool is a true false value, with no quotes
bool isAwake = true;
Console.WriteLine(isAwake);

// Integers, or int, are whole numbers
int age = 42;
Console.WriteLine(age);

// Double is a decimal type (can have up to 15-16 digit precision with a 64-bit size)
double notAwholeNumber = 42.5;
double withASuffix = 37.1d;
Console.WriteLine(notAwholeNumber + withASuffix);

// Float is also a decimal type(need to add a "f" at end of the number), float is stored as 32 bits, half the size of a double
float anotherDecimal = 3.14f;
Console.WriteLine(anotherDecimal);

// Decimal is a very precise decimal (64bit)
decimal aLargeDecimal = 8.3333333333333333m;
Console.WriteLine(aLargeDecimal);

//3.1415926535897932384626433832795028841971
Console.WriteLine("Float: " + 3.1415926535897932384626433832795028841971f); //when you don't need to be precise (least precise)
Console.WriteLine("Double: " + 3.1415926535897932384626433832795028841971d);
Console.WriteLine("Decimal: " + 3.1415926535897932384626433832795028841971m); //most precise

// Strings (Collections of characters)
// Strings in c# use double quotes

string myName = "Marla";
Console.WriteLine(myName);

//Characters (char)
// single character, number, symbol, etc.
// Characters use single quotes

char mander = '4';
char space = ' ';
char symbol = '@';
char escapeCharacter = '\n';
Console.WriteLine(mander + space + symbol + escapeCharacter);


// 5-15-23 notes
//Reference Types
//Variables that hold a reference rather than a value

//array type[], variable: ourClass
string[] ourClass = {
    "Braulio",
    "Brianne",
    "Edwin",
    "Garrett",
    "Isaac",
    "Jackson",
    "Marla",
    "Shelby"
};
                            //.Length is a property
Console.WriteLine(ourClass.Length);
string [] sd167 = ourClass;

Console.WriteLine(sd167.Length);  //also 8 items long //sd167 is a reference to ourClass which is why shows the same value

//Reading from an array index
Console.WriteLine(sd167[5]); //Jackson is the index of 5 

//Writing to an array index
sd167[5] = "Jackson Lee";

//OurClass and sd167 are two different variables but hold the same reference
Console.WriteLine(ourClass[5]); //shows Jackson Lee
Console.WriteLine(sd167[5]); //shows Jackson Lee



Bed myBed = new Bed();
myBed.NumberOfPillows = 2; //assigning property values to myBed
myBed.Color = "Gray";

//Assigns the reference that myBed holds to the variable thisBed
Bed thisBed = myBed;

Console.WriteLine(thisBed.Color);

//changing the value at the reference (myBed) so also changing the thisBed value
myBed.Color="Blue";

Console.WriteLine(thisBed.Color);

//says that these two were equal
Console.WriteLine(myBed ==thisBed);

thisBed = new Bed(); //made to be a new instance so now has its own reference
thisBed.Color = "Blue";
thisBed.NumberOfPillows = 2;

Console.WriteLine($"A {thisBed.Color} bed with {thisBed.NumberOfPillows} pillows.");
Console.WriteLine($"A {myBed.Color} bed with {myBed.NumberOfPillows} pillows.");

//this is now false because their references no longer match because of new instance
Console.WriteLine(myBed == thisBed);

Console.WriteLine(myBed.Color == thisBed.Color); //this is true because the values are currently the same even though objects are different

// Lists
// An expandable collection in c# (like a javascript array)

// Declare a list
//do the <> for the class List
List<string> listOfStrings = new List<string>();
List<int> listOfIntegers = new List<int>();



// Add to lists
listOfStrings.Add("First string for our list.");
listOfIntegers.Add(5849);


for (int i = 0; i< 1000; i++)
{
    listOfIntegers.Add(i);
}


// How we read (get values from the list)
string firstString = listOfStrings[0];

//Can write to index as well
listOfIntegers[0] = 219;

//Remove from a list //Remove also returns a boolean to know if removed or not
listOfStrings.Remove("First string for our list.");

listOfIntegers.RemoveAt(0);
listOfIntegers.RemoveRange(60, 200); //starting at 60 then removing 200
listOfIntegers.RemoveAll(number => number % 2 == 0); //removing all even numbers

foreach (int num in listOfIntegers)
{
    Console.Write(num + ","); //putting commas in between
}




//Queues
// Like a list but order matters
// First in First Out manner (FIFO)

Queue<string> firstInFirstOutCollection = new Queue<string>();
// Add to a queue (enqueue-adds to the end)

firstInFirstOutCollection.Enqueue("I'm first!");
firstInFirstOutCollection.Enqueue("I'm next!");

// ability to peek at the front of the queue without changing (Peek)
string first = firstInFirstOutCollection.Peek();
Console.WriteLine(first);

//Remove an item from the front of the string (Dequeue)
string removedItem = firstInFirstOutCollection.Dequeue();
Console.WriteLine(firstInFirstOutCollection.Count); // .Count get the number of elements in the queue



//STACK
// STACK is the opposite of a queue
// FIRST IN LAST OUT(last in first out)

Stack<string> lastInFirstOut = new Stack<string>();
lastInFirstOut.Push("Add to the stack"); //.Push inserts an object at the top of the stack
lastInFirstOut.Pop();  //Remove from the stack



// DICTIONARY
// Key value pair collections
//takes in 2 different types (one for key and one for value)

//Dictionary<KeyType, ValueType> name = new Dictionary<keyType, valueType>();
Dictionary<int, string> keyAndValue = new Dictionary<int,string> ();
keyAndValue.Add(7, "Agent");
keyAndValue.Add(219, "Another string");

string valueSeven = keyAndValue[7];
keyAndValue[7]= "Any string value we want to pass in";
Console.WriteLine(valueSeven);

Dictionary<string, Bed> beds = new Dictionary<string, Bed>();
beds.Add("mine", myBed);
beds.Add("that one", thisBed);

string? myBedColor = beds ["mine"].Color;
Console.WriteLine(myBedColor);


// DateTime Type
DateTime birthday = new DateTime( 2018, 8, 22);
DateTime todayDate = DateTime.Today; //
DateTime nowTime = DateTime.Now; //current date and time

TimeSpan AriAge = nowTime - birthday; //gives a time span
Console.WriteLine(AriAge.TotalDays /365.25);




// Enum (short for enumerator)
// A basic type that has a set number of values
// values associated by a THEME of some sort
// examples: days of the week, months of the year, hours of the day
WeekDays day = WeekDays.Wednesday;
if (day == WeekDays.Saturday)
{
    Console.WriteLine("Yay");
}


switch (day)
{
    case WeekDays.Monday:
    break;
    case WeekDays.Tuesday:
    break;
    case WeekDays.Wednesday:
    break;
    case WeekDays.Thursday:
    break;
    case WeekDays.Friday:
    break;
    case WeekDays.Saturday:
    break;
    case WeekDays.Sunday:
    break;

}


enum WeekDays{  Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
//keyword enum and typename {values}

enum Months{ Jan = 1, Feb = 2, Mar =3, April =4}
//can assign value (=1) so that not starting at 0







class Bed
{
public int NumberOfPillows {get;set;}

public string? Color {get;set;}
}