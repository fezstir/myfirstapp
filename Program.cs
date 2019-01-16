using System;
using Lessons;
using QuizClass;




// This namespace represents the folder that the file is in 

namespace classwork
{
    // Class is  blueprint of an object.
    class Program

    // Static is a single occurrence, void has no data returned (return type).
    {
        static void Main(string[] args)
        // Main is the method name, string[] is an array with a parameter
        {

            //Console.WriteLine("Hello World!");
            // Console is a class, Writeline is a method with a parameter

            //MyHouseResults();
            // MyNumericExamples();
            //OtherNumericExample();
            //MyStringExamples();
            //StatementSamples();
            //BottlesSong();
            //HouseSamples();
            //StructSample();
            //MathQuiz();
            //GradeQuiz();
            //FruitSample();
            //Sample11();
            ModifierExamples();

        }




        static void ModifierExamples()
        {
            int test = 14;
            lesson11 myLesson = new lesson11();

            myLesson.RefSample(ref test);
            Console.WriteLine(test);
            // Output = 19

            string myTestName, myTestSecondName, myTestLast;

            myLesson.OutSample("Johnathon williams Maniacs", out myTestName, out myTestSecondName, out myTestLast);

            Console.WriteLine(myTestName);
            Console.WriteLine(myTestSecondName);
            Console.WriteLine(myTestLast);

            // Output - myTestName = John & mySecondName = Doe
            decimal dividend = Decimal.One;
            decimal divisor = 3;
            Console.WriteLine(dividend / divisor * divisor);



        }



        static void Sample11()
        {
            lesson11 lesson = new lesson11();
            lesson.UseParams(10, 3, 24, 36, 45, 120);

            lesson.UseParams();

            int[] intArray = { 2, 3, 4, 5, 6 };
            lesson.UseParams(intArray);

            lesson.UseParams2(1, "Happy", false, 34.5F);

            lesson.OptionalParmas("Roger");
            lesson.OptionalParmas("Mathew", 14);

            lesson11 sl = new lesson11();
            sl.Samplelesson11();
        }

        static void FruitSample()
        {
            apple myApple = new apple();
            myApple.EatFruit();
            fruit myFruit = new apple();
            myFruit.EatFruit();
            Orange myOrange = new Orange();
            myOrange.EatFruit();
            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);
        }
        //static void MathQuiz()
        /*/{
            MathQuiz mathquiz = new MathQuiz();
        mathquiz.math50();
        }
    /static void GradeQuiz()
    {

        GradeQuiz gradequiz = new GradeQuiz();
        gradequiz.Grade();





    }
    */


        static void StructSample()
        {
            BookSample bookSample = new BookSample(4.99m, "zombie fallout", "Mrk Tufo");
            Console.WriteLine("the book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);
        }


        static void HouseSamples()
        {
            House myHouse = new House("concrete", "triple pane");
            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);

            myHouse.OpenDoor(true);


        }

        static void StatementSamples()
        {
            StatementExamples se = new StatementExamples();
            //se.SampleIf();
            //se.SampleElse();
            //se.SampleIfChain();
            //se.SampleIfAnd();
            //se.SampleIfOr();
            //se.SampleConditional();
            //se.SampleSwitch(5);
            //se.SampleWhile();
            //se.SampleDoWhile();
            //se.SampleFor();
            //se.ForEachLoopExample();
            //string myString = se.JumpStatementExample("Sunday");
            //Console.WriteLine(myString);

            se.SampleDays(DaysOfWeek.Sat);
        }

        static void BottlesSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            string song = beer.BottlesofBeerSong();
            // Console.WriteLine(song);

        }

        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Hello", "C#", "Class");

            Console.WriteLine(words);
            myTypes.CharTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceholderExample();
            myTypes.ArraySample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();
        }

        static void MyNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();
            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);
            Console.WriteLine(myTypes.LongFormInt(5600));
            myTypes.BasicMath();

            myTypes.CheckOperators();
            myTypes.IncrementDecrement();
            Console.WriteLine(myTypes.LongFormInt(5600));
            myTypes.SpecialValues();
            myTypes.ComparisonOperators();
            myTypes.OtherOperators();
        }
        static void OtherNumericExample()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.OtherOperators();
        }

        static void MyHouseResults()
        {
            // create and object instance of House called myHouse  
            House myHouse = new House();
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor();

            Console.WriteLine(myHouse.PaintDoor);

            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";


            Computer Computerpc = new Computer();
            Computerpc.TurnOn();

            Computerpc.ram = "3 gib";
            Computerpc.OperatingSystem = "PC";
            Computerpc.ProcessorSpeed = "1Ghz";

            Console.WriteLine(Computerpc.OperatingSystem);



        }
    }
}


