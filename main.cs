// Created by: Alex Nelson
// Created on: Nov 2022
//
// This program tells you which age range of movies you can
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Input
        Console.WriteLine("Students between 12 and 21 recieve a discount to the museum on weekdays. Enter in your age and the day you're visiting the museum below ");
        Console.WriteLine("");
        Console.WriteLine("Please enter your age");
        //input
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Please enter the day as a number(Monday being 1, and Sunday being 7)");
        //input
        int day = Convert.ToInt32(Console.ReadLine());
        //Procces
        Console.WriteLine("");
        //Procces
        if (day > 7)
        {
            Console.WriteLine("You have input something incorrectly. Please relaunch code.");
        }
        else if ((age > 12 && age < 21) && (day != 6 && day != 7))
        {
            //Output
            Console.WriteLine("Eligible!");
        }
        //Output
        else
        {
            Console.WriteLine("Not Eligible!");
        }
        Console.WriteLine("\nDone");
    }
}
