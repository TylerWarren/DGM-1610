using System;

public class program
{
	public void Main()
	{
		Console.WriteLine("Hello");
		DoMath(30, 12);
		DoMath(23, 9);
		DoMath(26, 11);
	}
	
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      if (46 > 31) 
      {
        Console.WriteLine("31 is less than 46");
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
      int time = 20;
      if (time < 18) 
      {
        Console.WriteLine("Good morning.");
      } 
      else 
      {
        Console.WriteLine("Good afternoon.");
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
      int day = 4;
      switch (day) 
      {
        case 6:
          Console.WriteLine("Today is Friday.");
          break;
        case 7:
          Console.WriteLine("Today is Saterday.");
          break;
        default:
          Console.WriteLine(" I am looking forward to the game tomarrow.");
          break;
      }    
    }
  }
}