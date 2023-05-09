//booleans operators (NOT, AND, OR, XOR->exclusive or)

bool csharpIsCool = false;
csharpIsCool = true;
Console.WriteLine(csharpIsCool);

// Boolean Logical Operators
//Logical NOT operator, Negation Operator
bool isTrue = !false;
bool isFalse = !true;


// AND Operator

bool trueAndExample = true && true;
bool falseAndExample = true && false;

// OR Operator

bool trueOrExample = true || false;
bool falseOrExample = false || false;

// XOR Operator (Exclusive Or) Only one can be true
bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;

// (condition 1 && not condition 2) || (not condition 1 && condition 2)->either of these sides need to be true

// Comparison Operators
// Equal, Not Equal, greater than, and Less Than

bool isGreaterThan = 10 > 10; //(false)
bool isGreaterThanOrEqualTo = 10 >= 10; //true

// Equality in c# uses 2 characters (== or !=) never 3 equals
bool equality = 17 == 9;
bool inequality = 17 != 9;

