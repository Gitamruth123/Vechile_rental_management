using System;
public class RentalAgency
{
  private List<Vehicle> Fleet { get; set; } = new List<Vehicle>();
  public decimal TotalRevenue { get; private set; }

  public void AddVehicle(Vehicle vehicle)
  {
      Fleet.Add(vehicle);
        
  }

  public void RemoveVehicle(Vehicle vehicle)
  {
      Fleet.Remove(vehicle);
  }

  public void RentVehicle(Vehicle vehicle, int days)
  {
      if (Fleet.Contains(vehicle))
      {
          TotalRevenue += vehicle.RentalPrice * days;
          Fleet.Remove(vehicle);
          Console.WriteLine(vehicle.Model + " has been rented for " + days + " days.");
          Console.WriteLine();
      }
      else
      {
          Console.WriteLine(vehicle.Model + " is not available.");
      }
  }

  public void DisplayFleet()
  {
      Console.WriteLine("Current Fleet:");
      Console.WriteLine();
      foreach (var vehicle in Fleet)
      {
          vehicle.DisplayDetails();
          Console.WriteLine("---------------------------");
      }
  }
}
