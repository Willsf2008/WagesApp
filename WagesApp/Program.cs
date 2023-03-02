//imports
using System;
using System.Collections.Generic;

namespace WagesApp
{
    class Program
    {

        //global variables


        //methods and/or functions

        static void CalculateWages(int totalHoursWorked)
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



            //Calculate wage at a rate of $22/hr

            int wages = totalHoursWorked * 22;

            //Calculate tax

            //Calculate final pay

            //Display the results of the calculations followed by two blank lines
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
            CalculateWages(sumHoursWorked);

        }



        //when run or main process
        static void Main(string[] args)
        {
            OneEmployee();
        }
    }
}