//Ask the user for the following input.  Turn it into a short story.

using MethodsExercise2;
using System;
using System.ComponentModel;

Console.WriteLine("---------------------Step 5c ----------------------");
//Methods.Exercise1();


Console.WriteLine("---------------------- Step 6 ----------------------");
//add, subtract, multiply, divide, modulus



Console.Write("Addition answer is:");
Console.WriteLine(Methods.Add(2, 2));

Console.Write("Subtraction answer is:");
Console.WriteLine(Methods.Sub(5, 3));

Console.Write("Multiplication answer is:");
Console.WriteLine(Methods.Multiply(2, 2, 2));


Console.Write("Multiplication answer is:");
Console.WriteLine(Methods.Divide(4, 3));

Console.Write("Modulus answer is:");
Console.WriteLine(Methods.Modulus(20, 5));


Console.WriteLine("---------------------- Step 8 Bonus ----------------------");
//Change the functions to us the params keyword to support a range of arguements.
//Add() methhod that takes as many arguements as needed

//a. Sum(2,4) would return 6
Console.WriteLine(Methods.BonusParams(2,4));

//a. Sum(2,4,6) would return 12
Console.WriteLine(Methods.BonusParams(2,4,6));

//a. Sum(1,1,1,1,1) would return 5
Console.WriteLine(Methods.BonusParams(1,1,1,1,1));