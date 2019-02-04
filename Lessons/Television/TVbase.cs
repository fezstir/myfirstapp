namespace myfirstapp.Lessons.Television
{
    public class TVbase
    {
        
        // the following are fields
        string _size;
        string _price;
        string _ports;
        string _mounts;

        //Auto properties



        public string size 
        {
             get{ return _size}; set{ this.size}; }

        public string HDDcapacity { get; set; }

        //long standard properties
        public string ProcessorSpeed
        {
            get
            {
                return _procesorSpeed;
            }
            set
            {
                this._procesorSpeed = value;
            }
        }
        public string VideoResolution
        {
            get
            {
                return _videoResolution;
            }
            set
            {
                this._videoResolution = value;
            }
        }
        public string OperatingSystem
        {
            get
            {
                return _operatingSystem;
            }
            set
            {
                this._operatingSystem = value;
            }
        }

        public Computer() { }

        public Computer(string _ram, string _hddCapacity)
        {
            this._procesorSpeed = ProcessorSpeed;
            this._videoResolution = "vga";
            this._operatingSystem = "windows";
        }

        public void TurnOn(bool isOn)
        {
            if (isOn)
            {
                Console.WriteLine("computer is on");
            }
            else
            {
                Console.WriteLine("computer is off");
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

        public struct ComputerSample
        {
            public decimal ram;
            public string OperatingSystem;
            public string HDDcapacity;

            public ComputerSample(decimal ram, string OperatingSystem, string HDDcapacity)
            {
                this.ram = ram;
                this.OperatingSystem = OperatingSystem;
                this.HDDcapacity = HDDcapacity;
            }
        }
    }
}