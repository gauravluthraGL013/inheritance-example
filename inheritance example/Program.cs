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
            public void set_vname(string v_name)
            {
                name = v_name;
            }
        }

        // Derived Class
        public class Truck : vehicle
        {
            public Truck()
            {
                Console.WriteLine("i  am in the derived class");
                Truck truck_obj = new Truck();
                truck_obj.name = "mercedes";
                
                    
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Truck truck_obj = new Truck();

            truck_obj.name = "mercedes";
            truck_obj.set_vname("toyota");

        }
    }
}
