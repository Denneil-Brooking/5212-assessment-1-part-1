using System;

namespace part_1
{
    //first section(class) start
    class Car
    //first section end
    {
        //second section(attri) start
        private string colour; //holds user input for colour
        private string make; //holds user input for make
        private string gearbox; //hold user input for gearbox
        //second section(attri) end
        //third section(opera) start
        public string GetColour()
        {
            return colour;
        }
        public void SetColour(string col)
        {
            colour = col;
        }
        public string GetMake()
        {
            return make;
        }
        public void SetMake(string mk)
        {
            make = mk;
        }
        public string GetGearbox()
        {
            return gearbox;
        }
        public void SetGearbox(string gbox)
        {
            gearbox = gbox;
        }
        public string DescribeCar()
        {
            return "This car is a " + colour + " " + make + " with a " + gearbox;
        }
        //third section(opera) end
    }
    //first section(class) end
    //main section
    class Program
    {
        static void Main(string[] args)
        {
            //Program start introduce program
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This Program takes user input on the asked fields and returns it");
            Console.WriteLine("------------------------------------------");
            //Run Car
            Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
            Car car = new Car();

            Console.Write("Colour: ");
            var UserColour = Console.ReadLine();
            car.SetColour(UserColour);

            Console.Write("Make: ");
            var UserMake = Console.ReadLine();
            car.SetMake(UserMake);

            Console.Write("Gearbox: ");
            var UserGearbox = Console.ReadLine();
            car.SetGearbox(UserGearbox);
            Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
            //Return feature
            Console.WriteLine(car.DescribeCar());

            Console.WriteLine("--*--*--*--*--*--*--*--*--*--*--*--*--*--*--");
            //program end
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("**************PROGRAM END***************");
            Console.WriteLine("Please Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
