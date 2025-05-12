using System;

// https://open.kattis.com/problems/fizzbuzz

namespace FizzBuzz {
    class Program {
        static void Main(string[] args) {
            int x = 3;
            int y = 5;
            int n = 7;

            for (int i = 1; i <= n; i++) {
                if (i % x == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % y == 0) {
                    Console.WriteLine("Buzz");
                } else if (i % x == 0 && i % y == 0) {
                    Console.WriteLine("FizzBuzz");
                } else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}