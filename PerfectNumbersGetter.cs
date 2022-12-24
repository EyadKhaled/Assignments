/*
    Project #2 : Get all perfect numbers between two numbers
    Made by: Eyad Khaled Mohamed
*/

using System;

namespace PerfectNumbersGetter {
    class Program {
        static void Main(string[] args) {
            // Print title
            Console.WriteLine("Get perfect numbers between two numbers\n");
        
            // Ask user to enter lower value of interval
            Console.Write("Enter first number (from): ");
            int num1 = int.Parse(Console.ReadLine());
        
            // Ask user to enter upper value of interval
            Console.Write("Enter second number (to): ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++) {
                if (IsPerfectNumber(i)) {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPerfectNumber(int n) {
            if (n <= 0) return false;

            // A number is considered a perfect number if the sum of its divisors (excluding itself) is equal to itself
            int sum = 0;
            for (int i = 1; i < n; i++) {
                if (n % i == 0) {
                    sum += i;
                }
            }
            return sum == n;
        }
    }
}
