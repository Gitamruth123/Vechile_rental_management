using System;
public class Car1 : Vehicle
{
  public int Seats{ get; set; }
  public string EngineType{ get; set; }
  public string Transmission{ get; set; }
  public bool Convertible{ get; set; }

  public override void DisplayDetails()
  {
      base.DisplayDetails();
      Console.WriteLine("Seats: " + Seats);
      Console.WriteLine("Engine Type: " + EngineType);
      Console.WriteLine("Transmission: " + Transmission);
      Console.WriteLine("Convertible: " + Convertible);
  }
}
