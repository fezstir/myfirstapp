using System;
using System.Globalization;

namespace Lessons
{
    class Program
    {

        public enum FeetConvert
        {
            mm,
            cm,
            inch,
            m,
            yard,


        };

        public void ConversionToFeet(double value, FeetConvert feetConvert)
        {
            switch (feetConvert)
            {
                case FeetConvert.mm:
                    double total = value * 304.8;
                    Console.WriteLine(total + "millimeters");
                    break;
                case FeetConvert.cm:
                    total = value * 30.48;
                    Console.WriteLine(total + "centimeters");
                    break;
                case FeetConvert.inch:
                     total = value *6.75;
                    Console.WriteLine(total + "inches");
                    break;
                case FeetConvert.m:
                    total = value * 3.048;
                    Console.WriteLine(total + "meters");
                    break;
                case FeetConvert.yard:
                    total = value * 0.3333333;
                    Console.WriteLine(total + "yards");
                    break;
            }

        }

        public void Main()

        {
            
            
            GetItemMeas;

        }
    }
}

/* 
constant double mm;



public class QuizLab
{
    int year;
if (year > 999 || <10000)
public virtual bool IsLeapYear(int year);

    Console.WriteLine("Not a leap year");}
else if {year = 364 (Console.WriteLine("Yes, LEAP YEAR"))}

int feet;
public void Convert()
{
;
}
}
}
3. In the QuizLab class, create a method that will convert the length of feet
to the other lengths in the following chart using an enum representing each length type.
Print the results of the number of feet, the result, and the length its converting to.
Optional: Using the math class round the number to the nearest 1000th(decimal two places).


enum
304.8
millimeter
30.48
centimeter
12
inches
0.3048
meter
0.33333333333
yard



*/
