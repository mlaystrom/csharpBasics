//namespace acts as a wrapper for Classes
//top level statements must precede namespace for example: Console.Writeline();

using Classes;
//type name= new keyword and type constructor
//add Classes. in front of type name and constructor so that it's recognized by namespace or add using Classes; directive above type name and constructor
Classes.Donut boston = new Classes.Donut("Jelly Filled");
Console.WriteLine(boston.GetDonutType());

// 1: A donut class instance called glazed
//it uses the using statment to access the Donut class
Donut glazed = new Donut("doug glazed");
glazed.SetDonutType("Chocolate Cream");

//2: if didn't assign value to donutType field-> would return as null
// (Commenting this out because value is being added to statement) glazed.donutType = "doug glazed";
//3: reading the field about type
string type = glazed.GetDonutType();
Console.WriteLine(type);

glazed.Filling = "glazed"; //alligns with property: this is our set
Console.WriteLine(glazed.Filling); //this is our get

glazed.Topping = "sprinkles";//get
Console.WriteLine(glazed.Topping);//set

glazed.IsOnSpecial=false;
glazed.Price= 1.50;

namespace Classes 
{
class Donut//class with name Donut
{
    // FIELD, this example is Field donutType
    //The access modifier is our public/private
    //public before string makes accessible outside of the class (public field)
    //fields are often private and properties are public
    private string donutType;
    //Backing field (for property)
    //Starting fields with an _ is a naming convention
    private string?_topping;

     //CONSTRUCTOR function
     public Donut(string type)//declared parameter and assigning our constructor parameter to the field
     //whatever is passed into the constructor, passes it's value to the field
     {
donutType = type;
//this.donutType = type;
     }

     //PROPERTIES
     //public: access modifier
     //string?: property type
     //Filling: name
     //{get; set; }: accessors
     public string? Filling {get; set; }

     public double Price { get; set; }
     public bool IsOnSpecial { get; set; }
     public string? Topping
     {
        // The function/method that is executed when you read from the property
        get
        {
            return _topping;
        }
        set
        {
            //property = "..." -> "..." is represented as a value
            //Donut.Topping = value
            _topping = value?.ToUpper(); //optional chaining 
        }
     }

     //METHOD (A function inside an object)
     //public: access modifier
     //string: Return type (returning a string)
     //GetDonutType: Method name
     //(): group of parameters, no params means it is empty
     //GetDonutType(): Method Signature, must be unique -> name + parameters
     public string GetDonutType()
     {
        // returns our above field which is now private
        return donutType;
        // can use this: return this.donutType;
     }
     public void SetDonutType(string newType)
     {
        //overriding value of donut
        donutType = newType;
     }
}
}