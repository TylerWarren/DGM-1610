using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 20; i++) 
      {
        if (i == 5) 
        {
          break;
        }
        Console.WriteLine(i);
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
      int i = 0;
      while (i < 20) 
      {
        Console.WriteLine(i);
        i++;
        if (i == 4) 
        {
          break;
        }
      }    
    }
  }
}
