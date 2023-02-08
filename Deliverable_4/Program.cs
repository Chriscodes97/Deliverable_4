/*
  Program Author: Chris Parrado
  Date: 2/7/23
  Program description: C# application that demonstrate the use of arrays after getting input from users.
*/
using System;
namespace Deliverable_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];

            // Intitalize the fibonacci array
            fibonacci[0] = 0;

            fibonacci[1] = 1;


            for (int i = 2; i < fibonacci.Length; i++)
            {
                    
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                
            }

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("Fibonacci (" + i + ") = " + fibonacci[i]);
            }

        }
    }
}