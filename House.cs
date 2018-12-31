using System;
namespace classwork
{
    public class House
    {
        // the following are fields
        string _foundation;
        string _roof;
        string _window;
        string _door;

        // standard long way property
        public string Foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;
            }
        }
        // shorthand autoproperty property + field
        public string Roof { get; set; }
        // standrd longway property
        public string Window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;
            }
        }
        // Autoproperty shorthand property + field
        public string PaintDoor { get; set; }

        // following are methods:
        public void OpenDoor()
        {
            Console.WriteLine("The Door Opens");
        }

        public void CloseDoor()
        {
            Console.WriteLine("The Door Closes");
        }

    }
}