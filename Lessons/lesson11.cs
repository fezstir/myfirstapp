using System;
namespace Lessons

{
    public class lesson11
    {
        public const int MY_VLE = 25;
        /*
        Method to demonstrate a constnt that cannot change it's value
         */
        public void Samplelesson11()
        {
            const string today = "wednesday";
            // MY_VLE = 35;// cannot change value
            int total = MY_VLE * 2;
            Console.WriteLine(total);
        }

        public void UseParams(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + ",");
            }
            Console.WriteLine();
        }


        public void UseParams2(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
            Console.WriteLine();
        }

        public void OptionalParmas(string name, int age = 45)
        {
            Console.WriteLine(name + " is " + age + " years old");
        }


        public void RefSample(ref int value)
        {
            value = value + 5;
            Console.WriteLine(value);

            // Output = 19
        }

        public void OutSample(string name, out string firstName, out string midName, out string lastName)
        {
            int myIndex = name.IndexOf(' ');
            int lastIndex = name.LastIndexOf(' ');
            int mid = lastIndex - myIndex;
            firstName = name.Substring(0, myIndex);
            midName = name.Substring(myIndex + 1, mid);
            lastName = name.Substring(lastIndex + 1);

        }



    }

}
