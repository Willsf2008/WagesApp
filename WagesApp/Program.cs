//imports
using System;
using System.Collections.Generic;

namespace WagesApp
{
    class Program
    {

        //global variables
        static string topEarner = "";
        static int topEarnerHours = 0;


        //methods and/or functions

        static void CalculateWages(int totalHoursWorked, string employeeName)
        {
            //Display the total weekly hours stored
            Console.WriteLine($"Total hours worked : {totalHoursWorked}hrs");


            //Add 5 hours if sumHours >30
            if (totalHoursWorked > 30)
            {
                totalHoursWorked += 5;

                //If bonus hours have been given display correct amount
                Console.WriteLine($"5 bonus hours added: {totalHoursWorked}hrs");
            }
            if (totalHoursWorked > topEarnerHours)
            {
                topEarnerHours = totalHoursWorked;
                topEarner = employeeName;

            }



            //Calculate wage at a rate of $22/hr

            int wages = totalHoursWorked * 22;

            float tax = 0.07f;

            //Calculate tax
            if (wages > 450)
            {
               tax = 0.08f;
            }

            //Calculate final pay

            float finalPay = wages - (float)Math.Round(wages * tax,2);

            //Display the results of the calculations followed by two blank lines
            Console.WriteLine($"Weekly Pay: {wages}\n" +
                $"Tax Rate: {tax}\n" +
                $"Tax: {Math.Round(wages * tax, 2)}\n" +
                $"Final Pay: {finalPay}\n\n\n");
        }

        static void OneEmployee()
        {
            List<string> weekDays = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            //Enter and store employee name
            Console.WriteLine("Enter Employee Name:\n");
            string employeeName = Console.ReadLine();


            //Display employee name
            Console.WriteLine(employeeName);

            Random randGen = new Random();
            int sumHoursWorked = 0;

            //Loop 5 times
            for (int dayIndex = 0; dayIndex < 5; dayIndex++)
            {


                //Randomly generate the number of hours worked by a worker each day
                int hoursWorked = randGen.Next(2, 7);


                //Assign the name of the day of the week to a variable called day

                string day = weekDays[dayIndex];

                //Store the total number of hours worked over the five days
                sumHoursWorked += hoursWorked;


                //Display the name of the day and the number of hours generated for each worker
                Console.WriteLine($"\tHours worked on {day}: {hoursWorked}");

            }






            //Call the CalculateWages()
            CalculateWages(sumHoursWorked, employeeName);

        }



        //when run or main process
        static void Main(string[] args)
        {
            string flagMain = "";
            while (!flagMain.Equals("XXX") )
            {
                OneEmployee();

                Console.WriteLine("Press <Enter> to add another employee or type 'XXX' to quit");
                flagMain = Console.ReadLine();



            }
            Console.WriteLine($"Top Earner: {topEarner} working {topEarnerHours} hours");
            
        }
    }
}