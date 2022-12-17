// Created by: Alex Nelson
// Created on: Nov 2022
//
// This program tells you which age range of movies you can
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Explanation
        Console.WriteLine("This algorithm will be able to tell you the angles of any TRIANGLE. If the angles do not add up to 180 it is not a triangle.");
        Console.WriteLine("");
        //input variables for side lengths 1, 2, and 3
        Console.WriteLine("Please enter side length 1");
        double lengthA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Please enter side length 2");
        double lengthB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Please enter side length 3");
        double lengthC = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        //The Acos process that determines the angles of the triangles
        Console.WriteLine("");
        double angleA = Math.Acos((lengthB * lengthB + lengthC * lengthC - lengthA * lengthA) / (2 * lengthB * lengthC)) * (180 / Math.PI);
        double angleB = Math.Acos((lengthC * lengthC + lengthA * lengthA - lengthB * lengthB) / (2 * lengthC * lengthA)) * (180 / Math.PI);
        double angleC = Math.Acos((lengthA * lengthA + lengthB * lengthB - lengthC * lengthC) / (2 * lengthA * lengthB)) * (180 / Math.PI);
        //Sum of angels A, B, and C
        double sumOfAngles = (angleA + angleB + angleC);
        //Output for every triangle
        if (sumOfAngles != 180 && sumOfAngles != 180.00000000000003)
        {
            Console.WriteLine("Not a triangle.");
            Console.WriteLine(sumOfAngles);
        }
        else if (angleA == angleB && angleB == angleC)
        {
            Console.WriteLine("This is an equilateral triangle");
        }
        else if (angleA == angleB || angleA == angleC || angleB == angleC)
        {
            Console.WriteLine("This is an isoscolese triangle");
        }
        else if (angleA != angleB && angleA != angleC && angleB != angleC)
        {
            Console.WriteLine("This is a scalene triangle");
        }
        //Done
        Console.WriteLine("\nDone");
    }
}
