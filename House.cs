using System;
namespace classwork
{
    public class House
    {
        // the following are fields
        string _foundation;
        string _roof;
        string _window = "double pane";
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
        public string Roof { get; set; } = "composite";
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

        public House() { }

        public House(string foundation, string window)
        : this(foundation, window, "shingles", "Green")
        { }

        public House(string foundation, string window, string roof, string doorPaint)
        {
            this._foundation = foundation;
            this._window = window;
            Roof = roof;
            PaintDoor = doorPaint;
        }
        // following are methods:
        public void OpenDoor()
        {
            Console.WriteLine("The Door Opens");
        }
        public void OpenDoor(bool isExterior)
        {
            if (isExterior)
            {
                Console.WriteLine("Open Frontdoor");
            }
            else
            {
                Console.WriteLine("open Bedroom door");
            }
        }

        public void CloseDoor()
        {
            Console.WriteLine("The Door Closes");
        }

    }
}