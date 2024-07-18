using System;
class Program
{
  static void Main(string[] args)
  {
      RentalAgency rentalAgency = new RentalAgency();

      Car car = new Car { Model = "Jetta", Manufacturer = "Volksvagen", Year = 2021, RentalPrice = 55m, Seats = 6, EngineType = "V5", Transmission = "Automatic", Convertible = false };
      Truck truck = new Truck { Model = "VNR", Manufacturer = "Volvo", Year = 2020, RentalPrice = 85m, Capacity = 1000, TruckType = "Pickup", FourWheelDrive = true };
      Motorcycle motorcycle = new Motorcycle { Model = "Supercub", Manufacturer = "Honda", Year = 2023, RentalPrice = 50m, EngineCapacity = 650, FuelType = "Petrol", HasFairing = true };

      rentalAgency.AddVehicle(car);
      rentalAgency.AddVehicle(truck);
      rentalAgency.AddVehicle(motorcycle);

      rentalAgency.DisplayFleet();

      rentalAgency.RentVehicle(car, 5);
      rentalAgency.DisplayFleet();
      Console.WriteLine("Total Revenue: " + rentalAgency.TotalRevenue.ToString("$"));


  }
}
