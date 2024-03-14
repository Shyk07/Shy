using System;

namespace WALA
{
    class Calculator
    {
        public double Average(int math, int physics, int chemistry, int computerScience)
        {
            return (math + physics + chemistry + computerScience) / 4;
        }

        public char Grade(double average)
        {
            if (average >= 80)
                return 'A';
            if (average >= 70)
                return 'B';
            if (average >= 60)
                return 'C';
            if (average >= 50)
                return 'D';
            return 'F';
        }

        public string Marks(char grade)
        {
            switch (grade)
            {
                case 'A':
                    return "Excellent! Your grade is A";
                case 'B':
                    return "Good! Your grade is B";
                case 'C':
                    return "Satisfactory. Your grade is C";
                case 'D':
                    return "Pass. Your grade is D";
                default:
                    return "Fail. Your grade is F";
            }
        }
    }

    class Program
    { 
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Mathematics marks: ");
                int math = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Physics marks: ");
                int physics = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Chemistry marks: ");
                int chemistry = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Computer Science marks: ");
                int computerScience = int.Parse(Console.ReadLine());

                Calculator addup = new Calculator();
                double average = addup.Average(math, physics, chemistry, computerScience);
                char grade = addup.Grade(average);

                string i = addup.Marks(grade);
                Console.WriteLine(i);
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
