using System;
namespace Lessons
{
    public class Trex : Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("TRex eats");
        }
        public override void Habitat()
        { Console.WriteLine("land"); }
        public override void Move()
        {
            Console.WriteLine("TRex runs");
        }


    }

}