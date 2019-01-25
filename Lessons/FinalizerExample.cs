using System;
namespace Lessons
{
    public class FinalizerExample
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }


        public FinalizerExample(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.SecondName = lastName;
        }

        ~FinalizerExample()
        {
            System.Diagnostics.Trace.WriteLine("Finalozer called");
        }
    }
}