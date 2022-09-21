using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] Games = {"Sonic", "Mario", "Minecraft", "Halo"};
      foreach (string i in Games) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}