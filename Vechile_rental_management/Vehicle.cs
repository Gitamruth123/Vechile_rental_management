﻿using System;
public class Vehicle
{
  public string Model{ get; set; }
  public string Manufacturer{ get; set; }
  public int Year{ get; set; }
  public decimal RentalPrice{ get; set; }

  public virtual void DisplayDetails()
  {
    Console.WriteLine("Model: " + Model);
    Console.WriteLine("Manufacturer: " + Manufacturer);
    Console.WriteLine("Year: " + Year);
    Console.WriteLine("Rental Price: " + RentalPrice.ToString("C"));
  }
}
