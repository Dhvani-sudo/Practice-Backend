// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.CodeAnalysis;
public class Calculator
{
   // public static int Add(int a, int b)
    public int Add(int a, int b)
    {

        //a = 42;
        //b = 119;
        int sum = a + b;
        return sum;
    }
}

class Program
{
    static void Main()
    {
      Calculator calculator = new Calculator();
     int sum =  calculator.Add(42,119);
      // Calculator.Add(42, 119);
        //int a = 42; int b = 119;
       // Console.WriteLine("\nThe sum of two numbers is : {0} \n", Calculator);
       // Console.WriteLine("\n The sum of two numbers is : {0} \n", Calculator.Add(42, 119));
        Console.WriteLine("\n The sum of two numbers is : {0} \n",sum);
    }

}

   

