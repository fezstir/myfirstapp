using System;


/* This namespace represents the folder that the file is in 
multiline 
comment.  */
namespace classwork
{
    // Class is  blueprint of an object.
    class Program
    // Static is a single occurrence, void has no data returned (return type).
    {
        static void Main(string[] args)
        // Main is the method name, string[] is an array with a parameter
        {

            Console.WriteLine("Hello World!");
            // Console is a class, Writeline is a method with a parameter
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


