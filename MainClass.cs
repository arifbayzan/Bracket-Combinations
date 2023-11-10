using System;

class MainClass 
{

  public static int BracketCombinations(int num) 
  {
    // code goes here  
    return ((Factorial(2*num)) / ((Factorial(num+1))*(Factorial(num))));

  }
  public static int Factorial(int number)
  {
    if (number<=0)
    {
      return 1;
    }
    else
    {
      return number*Factorial(number-1);
    }

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine("Enter number of Brackets:");
    Console.WriteLine(BracketCombinations(Convert.ToInt32(Console.ReadLine())));
    
  }

}