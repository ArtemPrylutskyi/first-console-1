using System;
using System.Collections.Generic;

namespace SecondTaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Second Task Project ===");

            int a = 10;
            double b = 3.5;
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));

    
            bool result = (a > 5) && (b < 10);
            Console.WriteLine("Logical AND result: " + result);

          
            if (a > 5)
            {
                Console.WriteLine("a is greater than 5");
            }
            else if (a == 5)
            {
                Console.WriteLine("a is equal to 5");
            }
            else
            {
                Console.WriteLine("a is less than 5");
            }

          
            switch (a)
            {
                case 10:
                    Console.WriteLine("a is 10");
                    break;
                case 20:
                    Console.WriteLine("a is 20");
                    break;
                default:
                    Console.WriteLine("a is something else");
                    break;
            }

      
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("for loop:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("foreach loop:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("while loop:");
            int j = 0;
            while (j < numbers.Length)
            {
                Console.WriteLine(numbers[j]);
                j++;
            }

            Console.WriteLine("do-while loop:");
            int k = 0;
            do
            {
                Console.WriteLine(numbers[k]);
                k++;
            } while (k < numbers.Length);

  
            List<string> fruits = new List<string>() { "apple", "banana", "cherry" };
            Console.WriteLine("List elements:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

  
            MyClass obj1 = new MyClass();
            obj1.Name = "Default Object";
            obj1.PrintInfo();

            MyClass obj2 = new MyClass("Custom Object");
            obj2.PrintInfo();
        }
    }
}
