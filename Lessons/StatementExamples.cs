using System;
namespace Lessons
{
    public class StatementExamples
    {
        public void SampleIf()
        {
            int num = 10;
            Console.WriteLine("Before If Statement");
            if (num > 5)
            {
                Console.WriteLine("If statement was valid");
            }
            Console.WriteLine("After If Statement");
        }

        public void SampleElse()
        {
            int value = 15;
            Console.WriteLine("Before If Statement");
            if (value > 15)
            {
                Console.WriteLine("If Statement Execute");
            }
            else
            {
                Console.WriteLine("Else Statement Execute");
            }
            Console.WriteLine("After If Statement");
        }
        public void SampleIfChain()
        {
            int num = 15;
            Console.WriteLine("Before If");
            if (num > 15)
            {
                Console.WriteLine("If Executes");
            }
            else if (num == 15)
            {
                Console.WriteLine("Else If executes");
            }
            else
            {
                Console.WriteLine("Else executes");
            }
            Console.WriteLine("After If");
        }
        public void SampleIfAnd()
        {
            int num1 = 15, num2 = 20;
            Console.WriteLine("Before If");
            if (num1 < 20 && num2 > 19)
            {
                Console.WriteLine("If Executes");
            }
            else
            {
                Console.WriteLine("Else Executes");
            }
            Console.WriteLine("After If");
        }
        public void SampleIfOr()
        {
            int num1 = 15, num2 = 20;
            Console.WriteLine("Before If");
            if (num2 > 25 || num1 == 15)
            {
                Console.WriteLine("If executes");
            }
            else
            {
                Console.WriteLine("Else executes");
            }
            Console.WriteLine("After If");
        }

        public void SampleConditional()
        {
            int num = 20;
            string word = (num < 25) ? "its less" : "its more";
            Console.WriteLine(word);
        }

        public void SampleSwitch(int num)
        {
            switch (num)
            {
                case 5:
                    Console.WriteLine("5 was choosen");
                    break;
                case 10:
                    Console.WriteLine("10 was choosen");
                    break;
                case 15:
                    Console.WriteLine("15 was chosen");
                    break;
                case 20:
                    Console.WriteLine("20 was chosen");
                    break;
                default:
                    Console.WriteLine("Not one of the numbers");
                    break;
            }
        }

        public void SampleWhile()
        {
            int num = 0;
            while (num < 10)
            {
                Console.WriteLine("number = {0} ", num);
                num++;
            }
        }

        public void SampleDoWhile()
        {
            int num = 0;
            do
            {
                Console.WriteLine("number = " + num);
                num++;
            } while (num < 10);
        }

        public void SampleFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("number = {0}", i);
            }
        }

        public void ForEachLoopExample()
        {
            foreach (char ch in "Something")
            {
                Console.WriteLine(ch);
            }
        }

        public string JumpStatementExample(string day)
        {
            switch (day)
            {
                case "Sunday":
                    goto default;
                case "Monday":
                case "Tuesday":
                    return "Test Something Tuesday";
                default:
                    return "Test Nothing";
            }
        }

        public void SampleDays(DaysOfWeek days)
        {
            switch(days)
            {
                case DaysOfWeek.Fri:
                case DaysOfWeek.Sat:
                case DaysOfWeek.Sun:
                Console.WriteLine("The weekend is here.");
                
                break;
                case DaysOfWeek.Mon:
                case DaysOfWeek.Tue:
                case DaysOfWeek.Wed:
                case DaysOfWeek.Thu:
                Console.WriteLine("Still at Work");
                break;
            }
        }



    }
}