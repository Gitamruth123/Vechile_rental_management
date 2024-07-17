using System;
using System.Collections.Generic;
public class RentalAgency
{
  private List<Vehicle> Fleet{ get; set; }
  public decimal TotalRevenue{ get; private set; }

  public RentalAgency()
  {
     Fleet = new List<Vehicle>();
     TotalRevenue = 0;
  }

  public void AddVehicle(Vehicle vehicle)
  {
     Fleet.Add(vehicle);
     Console.WriteLine(vehicle.Model + " added to fleet.");
  }

  public void RemoveVehicle(Vehicle vehicle)
  {
     Fleet.Remove(vehicle);
     Console.WriteLine(vehicle.Model + " removed from fleet.");
  }
  public void RentVehicle(Vehicle vehicle, int days)
  {
     if (Fleet.Contains(vehicle))
     {
         decimal rentalCost = vehicle.RentalPrice * days;
         TotalRevenue += rentalCost;
         Console.WriteLine(vehicle.Model + " rented for " + days + " days at a cost of " + rentalCost.ToString("C") + ". Total revenue: " + TotalRevenue.ToString("C"));
     }
     else
     {
        Console.WriteLine(vehicle.Model + " is not available in the fleet.");
     }
  }
}
