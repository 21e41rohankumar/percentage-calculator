using System;

namespace Average
{
    class PercentageCalculator
    {
        public static void Main()
        {
            Console.WriteLine("6 Subject Percentage Calculator\n");
            double[] Marks = new double[6];
            double totalMarks = 0;

            for (int i = 0; i < 6; i++)
            {
                double inputMark = 0;
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write($"Enter the marks for subject {i + 1}: ");
                    string? input = Console.ReadLine();

                    if (double.TryParse(input, out inputMark))
                    {
                        validInput = true;
                        Marks[i] = inputMark;
                        totalMarks += inputMark;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                }
            }

            double MaxMarks = 600;
            double Percentage = (totalMarks / MaxMarks) * 100;

            Console.WriteLine($"\nTotal Marks: {totalMarks} / MaxMarks :{MaxMarks}");
            Console.WriteLine($"Final Overall Percentage: {Percentage}%");

            if (Percentage >= 40)
                Console.WriteLine($"You got {Percentage}% and you have passed.");
            else
                Console.WriteLine($"You got {Percentage}% and you have failed.");
        }
    }
}
