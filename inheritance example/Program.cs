using System;

namespace inheritance_example
{
    class Program
    {
        //Base Class

        public class vehicle
        {
            public string name { get; set; }
            private string make { get; set; }
            public vehicle()
            {
                Console.WriteLine("i am in the cosntructor vehicle");
            }
        }

        // Derived Class
        public class Truck : vehicle
        {
            public Truck()
            {
                Console.WriteLine("i  am in the derived class");
                Truck truck_obj = new Truck();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
