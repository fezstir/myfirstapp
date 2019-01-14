using System;
namespace classwork
{
    public class RanchStyle : House
    {
        public RanchStyle(string foundation, string window,
        string roof, string doorPaint)
        : base(foundation, window, roof, doorPaint)
        {
            Console.WriteLine("RanchStyle Constructor");
        }
   
    public RanchStyle(string foundation, string window)
    :base(foundation, window)
       {
        Console.WriteLine("Ranch Style Constroctor");
       }
    }
}