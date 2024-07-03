using System;

namespace Task5

{
    /*
     * Task 5
     * Student Mark system
     * Calculate with average marks with input from users.
     * 
    */
    public class StudentMarkSytem
    {

        public static double CalculateAverage(double MathematicsMark, double PhysicsMark, double ChemistryMark, double ComputerScienceMark)
        {
            // Calculate average
            double AverageMark = MathematicsMark + PhysicsMark + ChemistryMark + ComputerScienceMark;
            return AverageMark;
        }
        public static string getGrade(double AverageMark)
        {
            string grade;

            // condition statement depend on average marks
            if (AverageMark >= 80 && AverageMark <= 100) grade = "A";
            else if (AverageMark >= 70 && AverageMark < 80) grade = "B";
            else if (AverageMark >= 60 && AverageMark < 70) grade = "C";
            else if (AverageMark >= 50 && AverageMark < 60) grade = "D";
            else if (AverageMark < 50) grade = "F";
            else { grade = "ERROR"; }

            return grade;
        }
        public static void getResult(string grade)
        {
            try
            {
                string msg;
                // depend on grade to show the result
                switch (grade)
                {
                    case "A":
                        msg = "Excellent! Your grade is A";
                        break;
                    case "B":
                        msg = "Good! Your grade is B";
                        break;
                    case "C":
                        msg = "Satisfactory. Your grade is C";
                        break;
                    case "D":
                        msg = "Pass. Your grade is D";
                        break;
                    case "F":
                        msg = "Fail. Your grade is F";
                        break;
                    default:
                        msg = "Invalid! please try again. Maximum Average Marks is 100";
                        break;

                }
                Console.WriteLine(msg);

            }
            catch (FormatException)
            {
                // show error if user input wrong format
                Console.WriteLine("Invalid format!");
            }
            catch (Exception e)
            {
                // show another errors
                Console.WriteLine(e.Message);
            }
        }

        public static void Main()
        {
            try
            {
                //Declare varibles
                double MathematicsMark, PhysicsMark, ChemistryMark, ComputerScienceMark;

                // user input 4 subjects and get value. 
                Console.WriteLine("Please enter marks for 4 subjects (out of a maximum of 100)");
                Console.Write("Mathematics: ");
                MathematicsMark = Convert.ToDouble(Console.ReadLine());

                Console.Write("Physics: ");
                PhysicsMark = Convert.ToDouble(Console.ReadLine());

                Console.Write("Chemistry: ");
                ChemistryMark = Convert.ToDouble(Console.ReadLine());

                Console.Write("Computer Science: ");
                ComputerScienceMark = Convert.ToDouble(Console.ReadLine());

                // get value from CalculateAverage 
                Double AverageMark = CalculateAverage(MathematicsMark, PhysicsMark, ChemistryMark, ComputerScienceMark);
                Console.WriteLine("Your average mark is: {0} ", AverageMark);

                //get grade after calculate average
                string Grade = getGrade(AverageMark);

                // get result after get the grade
                getResult(Grade);
                
            }
            catch (FormatException)
            {
                // show error if user input wrong format
                Console.WriteLine("Invalid format! please input only number");
            }
            catch (Exception e)
            {
                // show another errors
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

    }
}