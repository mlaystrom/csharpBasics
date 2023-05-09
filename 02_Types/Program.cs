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
