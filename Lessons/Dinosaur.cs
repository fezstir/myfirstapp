using System;
namespace Lessons
{
    public abstract class Dinosaur
    {
        public string Travel { get; set; } = "Walk";
        public abstract void EatFood();
        public abstract void Habitat();
        public virtual void Move()
        {
            Console.WriteLine("the Dinosaur moves");
        }
        public virtual void Speed()
        {
            Console.WriteLine("the dinosaur is inescapable");
        }
    }
}