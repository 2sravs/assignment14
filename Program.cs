using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BasicCSharpAssignment
{   
    internal class Program
    {
        public static long CalculateFactorial(int n)
        {

            if (n == 0)
                return 1;


            return n * CalculateFactorial(n - 1);
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            //string input;
            //int age ;
            //Console.WriteLine("Hello,World!");
            //Console.WriteLine("Enter the users name");
            //input = Console.ReadLine();
            //Console.WriteLine("enter the age");
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Hello,{input} is {age} years old ");
            //int a , b ;
            //Console.WriteLine("Enter the Numbers a");
            //a  = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Numbers b");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("c= "+(a+b));
            //Console.WriteLine("d= " + (a - b));
            //Console.WriteLine("e= " + (a * b));
            //Console.WriteLine("f= " + (a / b));
            //Console.WriteLine("g= " + (a % b));
            //int x;
            //Console.WriteLine("Enter the Numbers x");
            //x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{

            //    Console.WriteLine("The Given Number is even:"+x);
            //}
            //else
            //{
            //    Console.WriteLine("The Given Number is not Even Number:"+x);
            //}
            int i = 1;
            while (i <= 10)
            {

                Console.WriteLine(i);
                i++;
            }
            int[] arr = new int[5];
            int Sum = 0, avg = 0;
            arr[0] = 11;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 4;
            arr[4] = 23;
            for (int s = 0; s < arr.Length; s++)
            {

                Sum += arr[s];

            }
            Console.WriteLine("sum of Array is:" + Sum);
            avg = Sum / arr.Length;
            Console.WriteLine("the Average is:" + avg);

            //task Factorial
            Console.WriteLine("Enter a positive integer to calculate its factorial:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Please enter a non-negative integer.");
            }
            Console.WriteLine("Enter the age:");
            string input = Console.ReadLine();
            if(int.TryParse(input,out int age))
            {
                if (age >= 0&& age <= 29)
                {
                    Console.WriteLine($"You Entered:{age} years old.");
                }
                else
                {
                    Console.WriteLine("Invalid age.Please enter a valid age betwwen 0 to 28.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.Please enter a valid integer for age");
            }
            Console.ReadKey();
        }     
    }
}

