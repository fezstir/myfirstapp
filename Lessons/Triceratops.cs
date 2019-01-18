using System;
namespace Lessons
{
    public class Triceratops : Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("triceratops eats");
        }
        public override void Habitat()
        {
            Console.WriteLine("mountain");
        }
        public override void Speed()
        {
            Console.WriteLine("pretty fsat");
        }
    }
}