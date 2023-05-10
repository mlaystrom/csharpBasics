//Bronze
//Write a loop to print the numbers 500 through 525




for (int i = 500; i <= 525; i++)
{
    
    Console.WriteLine(i);
}

//Silver
//Create a for loop to print the number from 0-100 by 5's


for (int i = 0; i <= 100; i+=5)//the i++ counter is now incrementing by 5 each time the loop runs
{
    
    Console.WriteLine(i);
}





//Gold
//Create a for loop to print the numbers 1-100. If the number is divisible by 3, print Fizz ->if divisible by 5, print Buzz, if it's divisble by both 3 and 5, print FizzBuzz


//   1      //2       //3     //4
for (int i = 1; i <= 100; i++)
{
    if (i % 3==0 && i % 5==0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3==0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5==0)
    {
        Console.WriteLine("Buzz");
    }
    else{
        Console.WriteLine(i);
    }
}