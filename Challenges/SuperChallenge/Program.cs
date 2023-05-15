/*
- Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.
- Next, do the same, except only print the letter if it's an 'i'. If it's any other letter, print "Not an i".
Bonus: After that, print the number of letters in the word (do this with code, not by counting manually and hard-coding the number).
Another Bonus: In part 2, also determine if the letter is 'L'. If it is, print 'L'
*/

string word = "Supercalifragilisticexpialidocious";

//foreach (type iterator in collection)
foreach (char c in word){  //-->foreach loop iterates through the characters of the string "word" (1)
  // Console.WriteLine(c);
  if (c== 'i')
  {
    Console.WriteLine(c);
  }
  else
  {
    Console.WriteLine("Not an i.");
  }

  switch(c)
  {
    case 'i':
    case 'l':
        Console.WriteLine(c);
        break;
    default:
        Console.WriteLine("Not an i or l.");
        break;
  }
  
}

//Counting total number of characters and individually list characters(bonus)

int numberOfCharacters = word.Length; //-->so this counts the number of characters in string then can access each character
Console.WriteLine(numberOfCharacters);

//char firstCharacter = word[0];
//Console.WriteLine(firstCharacter);
//char secondCharacter = word[1];
//Console.WriteLine(secondCharacter);

// Using the for loop

//      iterator; condition     ;i++
for (int i = 0; i < word.Length; i++)
{
    
    
    // get the character at the index of i in word
    char c = word[i];

    string output = c == 'i' || c =='l' //condition
        ? c.ToString()                  //what to return for true
        : "Not an i or l.";             //what to return for false

    Console.WriteLine(output);
    }

//syntax for a ternary expression
// boolean expression ? expression if true : expression if false;