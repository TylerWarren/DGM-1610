using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Football", "Backetball", "Tennis", "Soccer"};
      for (int i = 0; i < cars.Length; i++) 
      {
        Console.WriteLine(cars[i]);
      }
    }
  }
}