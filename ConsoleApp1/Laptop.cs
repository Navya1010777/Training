using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Laptop : ElectronicDevice
    {
        string modelNumber;
        double batteryLife;
        double screenSize;
        string processor;
        string ramSize;

        public Laptop()
        {

        }

        public Laptop(string modelNumber, double batteryLife, double screenSize, string processor, string ramSize, double powerConsumption, string brand, double warrantyYears, double price, double weight, string name, string color) : base(powerConsumption, brand, warrantyYears, price, weight, name, color)
        {
            this.modelNumber = modelNumber;
            this.batteryLife = batteryLife;
            this.screenSize = screenSize;
            this.processor = processor;
            this.ramSize = ramSize;
        }

        public override void DeviceDetails()
        {
            base.DeviceDetails();
            Console.WriteLine("-----------------------Device Type: Laptop--------------------------");
            Console.WriteLine($"Model Number: {modelNumber}");
            Console.WriteLine($"Battery Life: {batteryLife} hours");
            Console.WriteLine($"Screen size: {screenSize} inches");

        }



    }
}
