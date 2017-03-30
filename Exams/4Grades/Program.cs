using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programming Basics Exam - 18 December 2016

class Program
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        double studentsWith56 = 0;
        double studentsWith45 = 0;
        double studentsWith34 = 0;
        double studentsWith23 = 0;
        double gradesTotal = 0;
        for (int i = 0; i < students; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade < 3.00)
            {
                studentsWith23++;
                gradesTotal += grade;
            }
            else if (grade < 4.00)
            {
                studentsWith34++;
                gradesTotal += grade;
            }
            else if (grade < 5.00)
            {
                studentsWith45++;
                gradesTotal += grade;
            }
            else
            {
                studentsWith56++;
                gradesTotal += grade;
            }
        }
        double averageScore = gradesTotal / students;

        Console.WriteLine("Top students: {0:f2}%", studentsWith56/students *100);
        Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", studentsWith45/students*100);
        Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", studentsWith34/students*100);
        Console.WriteLine("Fail: {0:f2}%", studentsWith23/students*100);
        Console.WriteLine("Average: {0:f2}", averageScore);
    }
}

