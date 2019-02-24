using System;
namespace Lessons
{
    public class LabReults
    {
        
        public void Electric()
        {   
            Console.WriteLine("Ohm's law - do you want to solve for I(cureent/amps),V(volt), or R-esistance(ohm)?");
            string value = Console.ReadLine();

            switch (value)
            {
                case "I":
                    Console.WriteLine("Enter value for volt");
                    string volt = Console.ReadLine();

                    int v = Convert.ToInt32(volt);

                    Console.WriteLine("Enter Value for Resistnce - ohm");
                    string ohm = Console.ReadLine();
                    int r = Convert.ToInt32(ohm);
                    int i = v / r;
                    Console.WriteLine(i + "= I current amps");
                    Electric();

                case "V":
                    Console.WriteLine("Enter Amps");
                    string cur = Console.ReadLine();
                    i = Convert.ToInt32(cur);
                    Console.WriteLine("Enter Resistnce - ohms");
                    ohm = Console.ReadLine();
                    r = Convert.ToInt32(ohm);
                    v = i * r;
                    Console.WriteLine(v + "= V volts");
                    Electric();

                case "R":
                    Console.WriteLine("Enter value for Volt");
                    volt = Console.ReadLine();
                    v = Convert.ToInt32(volt);
                    Console.WriteLine("Enter Value for amps");
                    cur = Console.ReadLine();
                    i = Convert.ToInt32(cur);
                    r = v * i;
                    Console.WriteLine(r + "Resistance - Ohm");
                    Electric();

                default:
                    Console.WriteLine("You must enter I, V, or R");
                    Console.ReadLine();
                    Electric();



            }

        }

    }

}


