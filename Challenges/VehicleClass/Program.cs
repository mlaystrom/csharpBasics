
using Classes;

Vehicle myCar = new Vehicle();
Vehicle crv= new Vehicle("Honda", "CR-V", "Dark blue", VehicleType.Spaceship);

myCar.TypeOfVehicle = VehicleType.Car;
myCar.Make = "Honda";
myCar.Model = "Civic";
myCar.Mileage = 50000;
myCar.Color = "Silver";

//Can't set isRunning because the set is private
//myCar.Is running = true

myCar.TurnOn();
myCar.TurnOn();
Console.WriteLine(myCar.IsRunning);


myCar.TurnOff();
myCar.TurnOff();
Console.WriteLine(myCar.IsRunning);

myCar.TurnOnHazards();
myCar.ClearIndicator();
myCar.IndicateRight();


myCar.IndicateRight();