//don't need to use {} anymore after namespace
namespace Classes;

public enum VehicleType {Car, Truck, Van, Motercycle, Spaceship, Boat, Plane} //enum are good for a level of consistency..don't need to mess with uppercase and so on




//access modifier(public) class (class) ClassName (Vehicle)
public class Vehicle
{

    //Constructor Overloading(this is setting the value as default)
    public Vehicle()
    {
        Make = "Honda";
        Model = "Civic";
        Color= "Silver";
        TypeOfVehicle= VehicleType.Car;
    }

    public Vehicle(string make, string model, string color, VehicleType type)
    {
        // Property = parameter
        Make = make;
        Model = model;
        Color =color;
        TypeOfVehicle= type;
    }
    //adding properties (make, model, mileage, color)

    //access modifier(public) typename {accessors;}
    public string? Make { get; set;}
    public string? Model { get; set;}
    public double Mileage { get; set;}
    public string? Color { get; set;}
    public VehicleType TypeOfVehicle { get; set;} //added this after did the enum under namespace

    //Property with a private set (only change it in the class)
    public bool IsRunning { get; private set;} //notice added private access modifier to the set

    public Indicator RightIndicator {get; } = new Indicator("right");
    public Indicator LeftIndicator {get; } = new Indicator("left");


    //Methods (Actions)
    //a method to turn on vehicle and one to turn off
    // AccessModifier-public
    public void TurnOn()
    {
        if (IsRunning == false)
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on"); 
        }
        else
        {
            Console.WriteLine("The vehicle is already on.");
        }
       
    }

    public void TurnOff()
        {
            if (IsRunning)
            {
                IsRunning= false;
                Console.WriteLine("You turn the vehicle off.");
            }
            else
            {
                Console.WriteLine("The vehicle is already off.");
            }

        }
    


// Indicate Right
public void IndicateRight()
{
    if (IsRunning && !RightIndicator.IsFlashing)
    {
    RightIndicator.TurnOn();
    LeftIndicator.TurnOff();
    
    }
}
//Indicate Left

public void IndicateLeft()
{
    if (IsRunning && !LeftIndicator.IsFlashing)
    {
        LeftIndicator.TurnOn();
        RightIndicator.TurnOff();
    }
}
//Turn on Hazards

public void TurnOnHazards()
{
    RightIndicator.TurnOn();
    LeftIndicator.TurnOn();
}

//Clar all indicator
public void ClearIndicator()
{
    RightIndicator.TurnOff();
    LeftIndicator.TurnOff();
}
}