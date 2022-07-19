public class CarConsole{
  public double Speed {get; set;}
  public double Tachometer {get; set;}
  public double Fuel {get; set;}

  public double AddFuel(double Fuel){
    Fuel += fuel;
  }
}

public class Car {
  // public Car(){
  //   CarConsole = new CarConsole();
  // }

  // Properties
  public string Model {get; set;}
  public string Manufacturer {get; set;}
  public CarConsole CarConsole {get; set;} = new CarConsole();

  private bool _running = false;

  // Functionality
  public bool StartUp(){
    // Implementation
    if(!_running){
      if (CarConsole.Fuel > 0)
        return true;
    }
    return false;
  }

  public void Run(string destination){}
  // public bool Run(string destination){} // X
  public bool RunWithSuccess(string source, string destination){}

  public bool ShutDown (){
      if(_running) {
        _running=false;
        return true;
      }
      return false;
  }
}


// Program.cs
public class Program {
  public void main(){
    Car car = new Car();

    car.Model = "800";
    car.Manufacturer = "Maruti";
    car.CarConsole.AddFuel(100);

    var isStarted = car.StartUp();
    if(isStarted){
      car.Run("Mumbai");
      car.ShutDown();
    }
  }
}
