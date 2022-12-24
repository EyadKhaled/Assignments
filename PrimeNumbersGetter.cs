/*
    Project #1 : Get all prime numbers between two numbers
    Made by: Eyad Khaled Mohamed
*/
 
using System;

namespace PrimeNumbersGetter {
    class Program {
        static void Main(string[] args) {
            // Print title
            Console.WriteLine("Get prime numbers between two numbers\n");
     
            // Declare the variables
            int num1, num2, i, j, flag;
        
            // Ask user to enter lower value of interval
            Console.Write("Enter first number (from): ");
            num1 = int.Parse(Console.ReadLine());
        
            // Ask user to enter upper value of interval
            Console.Write("Enter second number (to): ");
            num2 = int.Parse(Console.ReadLine());
        
            // Print display message
            Console.WriteLine("\nPrime numbers between " + "{0} and {1} are: ", num1, num2);
        
            // Checking each number in the range
            for(i = num1; i <= num2; i++) {
                // Skip 1 and 0 and negative
                if (i <= 1)
                    continue;
        
                // flag variable to tell if i is prime or not
                flag = 1;
        
                for(j = 2; j <= i / 2; j++) {
                    if (i % j == 0) {
                        flag = 0;
                        break;
                    }
                }
        
                // flag = 1 means i is prime and flag = 0 means i is not prime
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }  
}
