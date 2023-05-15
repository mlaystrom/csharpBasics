/*

Assignment: Class Creation w/ Property
- Create a User class
- Give the user a FirstName, LastName, ID (an integer, with no setter), and BirthDate properties.
- Create constructor for this class that has parameters for all the necessary properties.
Bonus: Create a method that returns the full name of the user.
Double Bonus: Create a method that returns the age of the user in years.
**/

//Person object

using UserProject;


Person detail = new Person("Marla", "Laystrom", 5);    //after constructor added, needed to put value of "Marla" to this starting line to pass through constructor
//detail.firstName="Marla";     //This line is no longer valid after adding the constructor
detail.SetPersonType("Chris");
Console.WriteLine(detail.GetPersonType());

//LastName Property
detail.lastName = "Laystrom";//set
Console.WriteLine(detail.lastName);//get

//ID Property

Console.WriteLine(detail.ID);

Birthday bday = new Birthday(5, 12, 1980);
Console.WriteLine(bday.Day);

//Ask for the birth year
Console.Write("Enter your birth year: ");
string yearResponse = Console.ReadLine() ?? "0"; //ReadLine returns a string
int birthYear = int.Parse(yearResponse);//converting string into a number
birthYear = Convert.ToInt32(yearResponse);
Birthday birthday = new Birthday (1, 2, birthYear);

//DescribeUser is a top level function and VOID is the RETURN TYPE
//void DescribeUser(Person person)
//{
 //   string description = $"User #{person.ID} is {person.Name}"
 //   Console.WriteLine(description) ?? "";

 //Console.WLriteLine($"Their full name is {person.GetFullName()}");
//}

//DescribeUser(user1); --->invoking the DescriberUser function


//Ask the user for the firstName
//Console.WriteLine("What is your first name?");
//string firstName = Console.ReadLine() ?? "";

//Ask the user for the lastName
//Console.Write("Enter your last name: ");
//string lastName = Console.ReadLine() ?? "";

//Created a user instance called consoleUser
//User consoleUser = new User(2, firstName, lastName);

//DescribeUser(consoleUser);//passing consoleUser into DescribeUser

namespace UserProject
{
    class Person //my Person class
    {

        //FIELD
        private string firstName;

        //CONSTRUCTOR
        public Person(string type, string last, int id) 
        {
            firstName = type;
            lastName= last;
            ID=id;

           
        }

        //PROPERTIES
        public string lastName
        { get; set;}

        public int ID { get; }//no set for int //makes it a READ ONLY property //defining guidelines  that the only time can change ID is within the constructor

       public Birthday Birthday { get; set; }

       public string? middleName {get; set; }

       public string Name{
        get
        {
            //string concatenation
            string fullName = firstName + " " + lastName;
            return fullName;
        }
       }

        //METHOD
        public string GetPersonType()
        {
            return firstName;
        }

        //2nd METHOD
        public void SetPersonType(string type)
        {
            firstName = type;
        }
        
        public string GetFullName()     //Bonus 
        {
            string?[]names = {firstName, middleName, lastName};

           // string fullName = $"{firstName} {middleName} {lastName}";
            string fullName = string.Join (" ", names.OfType<string>());//using string join method to filter out null values (filtering out middle name because no value)
            return fullName;
        }

    }
     class Birthday{

        // Constructor

        public Birthday(int month, int day, int year) //declaring 
        {
            //property = parameter
            Month = month;
            Day = day;
            Year = year;
        }
        //Properties

        public int Day {get;  }//include set if we allow user to input their own birthday
        public int Month {get; }

        public int Year {get;  }
    }
    
}

//1. Person firstName = new Person (); on line 15 initialized a new instance of our Person class
//2. because the class is within the UserProject namespace, and the top level statments exist outside of that, we need the using statement at very top
//3. wrote the Person firstName = new Person () to console---> UserProject.Person (outputting the name of the class and includes the namespace)
//updated the Console.WriteLine info (detail.firstName) (which includes the public string field of firstName) 

//above the Console.WriteLine, assigned a value to detail.firstName of "Marla"

//after adding constructor, changed  modified the FIELD declaration to be private instead of public

//MeTHOD Name-->GetPersonType(not sure about this...) and returning a value help by firstName

//after adding METHOD NAME, added this to the console to call.  This will return the value helf by the FIELD

//2nd METHOD TYPE(string) --> void is the return type(used when there will be no value returned)

//The aregument in SetPersonType method takes over and replaces the value set in the constructor-->Ari replaces Marla in console

//Adding Properties (a member that provides a flexible mechanism to read, write, or compute the value of a PRIVATE FIELD)
//..they are special METHODS called ACCESSORS (get and set) which function like the GetPersonType and SetPersonType methods
//..assigned name of LastName to the public access modifier string

//Go over his video to redo so can get answers the way he did it
