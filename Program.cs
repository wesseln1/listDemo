using System;
using System.Collections.Generic;

namespace listDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a new list variable
            List<int> cohorts = new List<int>();

            cohorts.Add(34);
            cohorts.Add(35);
            cohorts.Add(36);
            cohorts.Add(37);

            // Another way to initialize this list
            List<string> classes = new List<string>()
            {
                "Cohort 34",
                "Cohort 35",
                "Cohort 36",
                "Cohort 37"
            };

            classes.Remove("Cohort 34");
            classes.Add("Cohort 38");

            foreach (string nssClass in classes)
            {
                if (nssClass == "Cohort 35")
                {
                    Console.WriteLine($"The Best Cohort: {nssClass}");
                }
                else
                {
                    Console.WriteLine($"A Perfectly Fine Cohort: {nssClass}");
                }
            }
            foreach (int classNumber in cohorts)
            {
                Console.WriteLine(classNumber);
            }
        }
    }
}