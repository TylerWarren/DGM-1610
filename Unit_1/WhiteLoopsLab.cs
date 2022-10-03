using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 5;
      while (i < 10) 
      {
        Console.WriteLine(i);
        i++;
      }
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 10;
      do 
      {
        Console.WriteLine(i);
        i++;
      }
      while (i < 20);
    }
  }
}