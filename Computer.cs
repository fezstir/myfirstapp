using System;
namespace classwork
{
    public class Computer
    {
        // the following are fields
        // string _ram;
        // string _hddCapacity;
        string _procesorSpeed;
        string _videoResolution;
        string _operatingSystem;

        //Auto properties
         

        
                public string ram {get; set;}
        public string HDDcapacity {get; set;}
        //long standard properties
        public string ProcessorSpeed {
            get{
                return _procesorSpeed;
            }
            set{
                this._procesorSpeed = value;
            }
        }
        public string VideoResolution {
            get{
                return _videoResolution;
            }
            set{
                this._videoResolution = value;
            }
        }
        public string OperatingSystem {
            get {
                return _operatingSystem;
            }
            set{
                this._operatingSystem = value;
            }
        }
         
         //the following are methods
         public void TurnOn() 
         {
            Console.WriteLine("computer is on");
         }

         public void TurnOff()
         {
            Console.WriteLine("Turning off"); 
         }

         public void Hibernate()
         {
            Console.WriteLine("Hibernating");
         }
    }
            
}
