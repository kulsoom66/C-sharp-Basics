﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Casting
            int n = 6;
            n = Convert.ToInt32(n);
            //n = int.Parse(Console.ReadLine());

            //declaring and initializing single dimentioal array
            int[] arr = new int[n];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            arr[5] = 6;

            // Two dimentional array
            int[,] Grades = new int[3, 3];
            Grades[0, 0] = 0;
            Grades[0, 1] = 1;
            Grades[1, 0] = 2;
            Grades[1, 1] = 3;

            //Jagged array
            int[][] Employees = new int[2][];
            Employees[0] = new int[3] {1,2,3};
            Employees[1] = new int[2] { 1, 2 };

            //accessing the second element of the first array in Employess
            Console.WriteLine(Employees[0][1]); 


            //if condition
            Console.WriteLine("Enter a number");
            int num =Convert.ToInt32(Console.ReadLine());
            if (num > 75)
            {
                Console.WriteLine("Succedd");
            }
            else if (num>=58)
            {
                Console.WriteLine("Failed");
            }


            //switch condition
            Console.WriteLine("Hello, please enter student's grades: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            //list of menu and thier prices
            string[] menu = { "Lattee", "Cappcino", "americano" };
            double[] price = { 3.65, 2.35, 4 };

            //displaying the menu
            Console.WriteLine("Menu: ");
            Console.WriteLine($"1.{menu[0]} -- {price[0]} $");
            Console.WriteLine($"2.{menu[1]} -- {price[1]} $");
            Console.WriteLine($"3.{menu[2]} -- {price[2]} $");








            switch{
                grade >=75:
                Console.WriteLine("Congrates, you have succeed");
            }


        }
    }
}


























































































































