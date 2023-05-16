// Create a class called Indicator that has a property called IsFlashing
// IsFlashing should have a private set 
// The Indicator class also then needs the methods required to change the state of the IsFlashing Property (TurnOn, TurnOff)

namespace Classes;




public class Indicator{

    private string _label; // Field
    public Indicator(string label)//Constructor
    {
        _label= label;
    }

//PROPERTY
//property called IsFlashing w/ a private set
 public bool IsFlashing { get; private set;} //notice added private access modifier to the set
 
 
 //METHOD

   public void TurnOn()
    {
        if (!IsFlashing)
        {
            IsFlashing = true;
            Console.WriteLine($"The {_label} indicator turns on.");
        }
        else
        {
            Console.WriteLine($"The {_label} indicator is already on.");
        }
    }
    public void TurnOff()
    {
        IsFlashing = false;
        Console.WriteLine($"The {_label} indicator turns off.");
    }
 
 }
 