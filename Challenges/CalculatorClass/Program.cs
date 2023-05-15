/*
Create a Calculator class that has the ability to complete all of the following processes (using methods), each taking in two number inputs:
- Add
- Subtract
- Multiply
- Divide
Bonus Challenges:
- Allow use of whole numbers and numbers with decimals //go in and change all int to double for decimals
- Have the ability to return fractions or percentages instead of decimals
- Allow the calculator to take in as many numbers as the user provides
*/
//class name is type
//type      name        new constructor-->same name as type 
Calculator calculator = new Calculator(); //new up a Calculator instance
int total = calculator.Add(16, 42); //declared int total because the type hasn't been declared before
double totald = calculator.Subtract(total, 5);//remove the double and d after total to make it not the overload
total = calculator.Multiply(total, 9);
total = calculator.Divide(total, 2);
Console.WriteLine(total);
class Calculator

{
// Add Method
    public int Add(int numOne, int numTwo)
    {
        int sum = numOne + numTwo;
        return sum;
    }

//This is a Method overload; same METHOD NAME but different parameter types
    public double Subtract (double numOne, double numTwo)
    {
        return numOne = numTwo;
    }

// Subtract Method
public int Subtract(int numOne, int numTwo)
    {
        return numOne - numTwo; //using inline
    }

//  Multiply Method  -->using expression body
public int Multiply(int numOne, int numTwo) => numOne * numTwo;  //RETURN is implied with the => expression


//  Divide Method

public int Divide (int numOne, int numTwo) => numOne / numTwo;
}
/*
accessModifier returnType Name(paramType paramName) { methodBody}

*/