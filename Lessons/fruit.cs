using System;
namespace Lessons
{
    public class fruit
    {
        public virtual void EatFruit()
        {
            Console.WriteLine("I et fruit");
        }

        private void ThrowFruit()
        {
            Console.WriteLine("Throwing Fruit");
        }

        public void FruitBowl()
        {
            ThrowFruit();
        }


    }


}