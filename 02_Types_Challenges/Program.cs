// Integers, or int, are whole numbers

int ageA;
int ageC = 13;
Console.WriteLine(ageC);

// Strings (Collections of characters)
// Strings in c# use double quotes
string car;
string carType = "Ford";
Console.WriteLine(carType);

// bool is a true false value, with no quotes
bool isTall;
bool isShort = true;
Console.WriteLine(isShort);

// Float is also a decimal type(need to add a "f" at end of the number), half the size of a double
float measureBits;
float randomNumbers = 1.456789f;
Console.WriteLine(randomNumbers);

// Double is a decimal type
double notAwholeNumber;
double withASuffix = 1.45678911230d;
Console.WriteLine(withASuffix);

// Decimal is a very precise decimal (64bit)
decimal aLargeDecimal = 33.888888888888888888888m;
Console.WriteLine(aLargeDecimal);

ulong uLong;
ulong confusingNumber = 98347598479357894;
Console.WriteLine(confusingNumber);

//SILVER (concatenate two string variables)

string firstName= "Marla";
string lastname= "Laystrom";
string myName= firstName + " " + lastname;
Console.WriteLine(myName);

int number = 43;
string howFun= "Trying this out";
string numberAndWords= number + howFun;
Console.WriteLine(numberAndWords);

//Gold (Create an int variable to hold a year. Need to gather the value for the year as a string then convert to an integer in C#)
string yearString = "2023";
int yearNumber = int.Parse(yearString); 
Console.WriteLine(yearNumber);

