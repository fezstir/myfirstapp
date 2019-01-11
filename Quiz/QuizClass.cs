using System;
namespace QuizClass
{
    public class MathQuiz
    {
        public void math50()
        {
            int val = 0;
            do
            {
                Console.WriteLine(val);
                val = val + 3;
            } while (val < 50);
        }
    }
    public class GradeQuiz
    {
        public void Grade()
        {


            string grade;
            Console.WriteLine("Enter Grade");
            do
            {
                grade = Console.ReadLine();
                while (grade != null) ;
            }
            if (grade != null)
                Console.WriteLine("   wrong   " + grade);
            while (grade != null)
            {



                if
                 (grade == "A")
                {
                    Console.WriteLine("Average");
                }
                else if
                (grade == "E") { Console.WriteLine("Excellent"); }

                else
                { Console.WriteLine("Grade statement was not valid, must be E,V,G,A, or F"); }
            }
        }

    }
}








