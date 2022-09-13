using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    internal class Methods
    {
        public static void Exercise1()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite number>");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hi {name}, nice to meet you.  I just learned that your favorite color is {color}, your " +
                $"favorite animal is a {animal} and your favorite number is {favoriteNumber}.  " +
                $"It is fun to learn things about you.");
        }

        
        //add, subtract, multiply, divide, modulus
        public static int Add(int num1, int num2) 
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2) 
        {
            return num1 - num2;

        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    
        public static int BonusParams(params int[] listOfNumbers)
        {
            int totalAdd = 0;
            foreach (int num in listOfNumbers)
            {
                totalAdd += num;
            }

            return totalAdd;
        }

        public static int Sum(params int[] parameters)
        {
            int sum = 0;
            for (int i= 0; i <parameters.Length; i++)
            {
                sum += parameters[i];
            }

            return sum;
        }

    }


}
