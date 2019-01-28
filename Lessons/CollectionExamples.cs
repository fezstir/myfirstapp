using System;
using System.Collections;
using System.Collections.Generic;
namespace Lessons
{

    public class CollectionExamples
    {

        public void MyListExample()
        {
            List<Dinosaur> myDino = new List<Dinosaur>();
            myDino.Add(new Trex());
            myDino.Add(new Trex() { Travel = "Stomp" });
            myDino.Add(new Triceratops() { Travel = "Trample" });

            foreach (Dinosaur dino in myDino)
            {
                Console.WriteLine("These dinosaurs move by {0}", dino.Travel);
                Console.WriteLine(dino);
            }

        }



        public void MyArrayListExample()
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Hello");
            myArrayList.Add("World");
            myArrayList.Add(42);
            myArrayList.Add(84);

            Console.WriteLine("Count = {0}", myArrayList.Count);

            myArrayList.Remove(42);
            myArrayList.RemoveAt(0);

            Console.WriteLine("Cont = {0}", myArrayList.Count);

            myArrayList.Add("Other");
            myArrayList.Add("Stuff");


            Console.WriteLine("Count = " + myArrayList.Count);

            foreach (Object item in myArrayList)
            {
                Console.WriteLine("type = {0}", item);
            }



        }
    }
}