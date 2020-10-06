using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
  
   
   int len = 7;
   double[] cel = new double[len];
   double[] far = new double [len];
   double averageFar = 0;
   double sum = 0;
   
   for (int counter = 0; counter < len; counter++)
   {
   Console.WriteLine("Enter temperature in Celsius:");
   cel[counter] = Convert.ToDouble(Console.ReadLine());
   far[counter] = (cel[counter] * 9/5) + 32;
   sum += far[counter];
   
   }
   averageFar = sum / len;
   Console.WriteLine("Temperature in Fahrenheit");
   
   Array.Reverse(far);
   
   foreach (double item in far)

   {
     Console.WriteLine(item);
   }
   
   Console.WriteLine("Average temperature is " + averageFar + " degrees fahrenheit ");

   

   
   
    
   
  }
}