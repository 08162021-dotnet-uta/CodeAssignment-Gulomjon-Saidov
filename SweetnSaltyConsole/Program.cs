using System;

namespace SweetnSaltyConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Print();
    }

    /// <summary>
    /// This method prints 1 through 1000, and when the number is multiple of 5 it prints salty, when multiple 
    /// of 3 it prints sweeet, and when multiple of 3 and 5 it prints sweetnSalty
    /// </summary>
    static void Print()
    {
      // declare three placeholder int variables for sweet, salty, and sweetnSalty.
      int sweetnSalty = 0; // number of (3 and 5)
      int sweet = 0; // number 3
      int salty = 0; // number 5

      int end = 11; // this is to increment the outer loop by 10
      for (int i = 1; i < 1001; i += 10)
      {
        string result = ""; // this string variable stores numbers in a group of 10
        for (int j = i; j < end; j++) // this inner for loop iterates every 10 numbers and stores them in result.
        {
          if (j % 5 == 0 && j % 3 == 0)
          {
            result += " sweet’nSalty";
            sweetnSalty++;
          }
          else if (j % 5 == 0)
          {
            result += " salty";
            salty++;
          }
          else if (j % 3 == 0)
          {
            result += " sweet";
            sweet++;
          }
          else
          {
            result += $" {j}";
          }

        }
        end += 10;
        Console.WriteLine(result.Trim());
      }

      Console.WriteLine($"sweet's: {sweet}\nsalty's: {salty}\nsweet’nSalty's: {sweetnSalty}");
    }
  }// End of class
}//End of Namespace
