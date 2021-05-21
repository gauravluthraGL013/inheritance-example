using System;

namespace inheritance_example
{
    class Program
    {
        //Base Class

        public class vehicle
        {
            public string name { get; set; }
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
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
