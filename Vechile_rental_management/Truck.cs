﻿using System;
public class Truck : Vehicle
{
  public int Capacity{ get; set; }
  public string TruckType{ get; set; }
  public bool FourWheelDrive{ get; set; }

  public override void DisplayDetails()
  {
      base.DisplayDetails();
      Console.WriteLine("Capacity: " + Capacity);
      Console.WriteLine("Truck Type: " + TruckType);
      Console.WriteLine("Four Wheel Drive: " + FourWheelDrive);
  }
}
