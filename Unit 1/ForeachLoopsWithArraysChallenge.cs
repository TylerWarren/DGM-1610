using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Honda", "BMW", "Ford", "Mazda"};
      foreach (string i in cars) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}