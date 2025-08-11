using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Device
    {
        double price;
        double weight;
        string name;
        string color;

        public Device()
        {

        }

        public Device(double price, double weight, string name, string color)
        {
            this.price = price;
            this.weight = weight;
            this.name = name;
            this.color = color;
        }
        public virtual void DeviceDetails()
        {
            Console.WriteLine("--------------------Product Details----------------------");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Price: Rs.{price:C}/-");
        }
    }
}
