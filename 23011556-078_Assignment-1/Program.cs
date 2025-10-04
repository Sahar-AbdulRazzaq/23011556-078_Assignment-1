// ============================================
// Assignment 1 - Visual Programming using C#
// Roll No: 23011556-078
// Student: Sahar Abdul Razzaq
// Submitted to: Sir Nouman Mazhar
// Subject: Visual Programming
// ============================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_078_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Assignment 1 - Sahar Abdul Razzaq");
            Console.WriteLine("Roll No: 23011556-078");
            Console.WriteLine("==================================");
            Console.WriteLine("Choose a Question (1 to 10): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: EvenOddSolver.Run(); break;
                case 2: MiniCalculator.Run(); break;
                case 3: GradeChecker.Run(); break;
                case 4: NaturalSum.Run(); break;
                case 5: MultiplicationPrinter.Run(); break;
                case 6: FactorialSolver.Run(); break;
                case 7: NumberReverser.Run(); break;
                case 8: FindMaxMin.Run(); break;
                case 9: CountEvenOdd.Run(); break;
                case 10: LinearSearchArray.Run(); break;
                default: Console.WriteLine("Invalid option selected."); break;
            }
        }
    }

    // ============== Q1: Even or Odd ==================
    class EvenOddSolver
    {
        public static void Run()
        {
            Console.Write("Enter any integer to check: ");
            int value = Convert.ToInt32(Console.ReadLine());

            string result = (value % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"The number {value} is {result}.");
        }
    }

    // ============== Q2: Simple Calculator ============
    class MiniCalculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation symbol (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            double answer = 0;
            bool valid = true;

            switch (op)
            {
                case '+': answer = first + second; break;
                case '-': answer = first - second; break;
                case '*': answer = first * second; break;
                case '/':
                    if (second != 0) answer = first / second;
                    else { Console.WriteLine("Division by zero is not allowed!"); valid = false; }
                    break;
                default: Console.WriteLine("Invalid operator."); valid = false; break;
            }

            if (valid)
                Console.WriteLine($"Result of {first} {op} {second} = {answer}");
        }
    }

    // ============== Q3: Grade Evaluator ==============
    class GradeChecker
    {
        public static void Run()
        {
            Console.Write("Enter marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            char grade;
            if (marks >= 85) grade = 'A';
            else if (marks >= 70) grade = 'B';
            else if (marks >= 55) grade = 'C';
            else if (marks >= 40) grade = 'D';
            else grade = 'F';

            Console.WriteLine($"Marks = {marks}, Grade = {grade}");
        }
    }

    // ============== Q4: Sum of Natural Numbers =======
    class NaturalSum
    {
        public static void Run()
        {
            Console.Write("Enter n to calculate sum from 1 to n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int total = 0;
            for (int i = 1; i <= n; i++)
                total += i;

            Console.WriteLine($"The sum of first {n} natural numbers = {total}");
        }
    }

    // ============== Q5: Multiplication Table =========
    class MultiplicationPrinter
    {
        public static void Run()
        {
            Console.Write("Enter a number to print its multiplication table: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num}");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    // ============== Q6: Factorial Calculator =========
    class FactorialSolver
    {
        public static void Run()
        {
            Console.Write("Enter a number to find factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long fact = 1;
            int i = 1;
            while (i <= n)
            {
                fact *= i;
                i++;
            }
            Console.WriteLine($"Factorial of {n} = {fact}");
        }
    }

    // ============== Q7: Reverse a Number =============
    class NumberReverser
    {
        public static void Run()
        {
            Console.Write("Enter a number to reverse: ");
            int original = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;

            while (original > 0)
            {
                int digit = original % 10;
                reversed = reversed * 10 + digit;
                original /= 10;
            }

            Console.WriteLine($"Reversed number = {reversed}");
        }
    }

    // ============== Q8: Find Max & Min in Array ======
    class FindMaxMin
    {
        public static void Run()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            int max = numbers[0], min = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            Console.WriteLine($"Maximum value = {max}, Minimum value = {min}");
        }
    }

    // ============== Q9: Count Even & Odd in Array ====
    class CountEvenOdd
    {
        public static void Run()
        {
            int[] values = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < values.Length; i++)
                values[i] = Convert.ToInt32(Console.ReadLine());

            int evens = 0, odds = 0;
            foreach (int v in values)
            {
                if (v % 2 == 0) evens++;
                else odds++;
            }

            Console.WriteLine($"Even count = {evens}, Odd count = {odds}");
        }
    }

    // ============== Q10: Search in Array =============
    class LinearSearchArray
    {
        public static void Run()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} numbers:");
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool exists = false;
            foreach (int val in arr)
            {
                if (val == search) { exists = true; break; }
            }

            if (exists) Console.WriteLine($"Yes! {search} exists in the array.");
            else Console.WriteLine($"{search} not found in the array.");
        }
    }
}
