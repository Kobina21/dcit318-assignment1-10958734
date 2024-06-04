using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grade Calculator!");
            Console.Write("Please enter your numerical grade: ");
            
            // Reading the input grade from the user
            int grade = Convert.ToInt32(Console.ReadLine());

            // Determining the corresponding letter grade
            string letterGrade;
            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // Displaying the result
            Console.WriteLine($"Your letter grade is: {letterGrade}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
