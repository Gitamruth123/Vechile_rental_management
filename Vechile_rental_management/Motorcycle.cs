using System;
public class Motorcycle1 : Vehicle
{
  public int EngineCapacity{ get; set; }
  public string FuelType{ get; set; }
  public bool HasFairing{ get; set; }

  public override void DisplayDetails()
  {
      base.DisplayDetails();
      Console.WriteLine("Engine Capacity: " + EngineCapacity);
      Console.WriteLine("Fuel Type: " + FuelType);
      Console.WriteLine("Has Fairing: " + HasFairing);
  }
}
