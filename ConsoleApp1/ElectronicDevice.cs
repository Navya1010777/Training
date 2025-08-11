using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ElectronicDevice : Device
    {
        double powerConsumption;
        string brand;
        double warrantyYears;
        public ElectronicDevice() { }
        public ElectronicDevice(double powerConsumption, string brand, double warrantyYears, double price, double weight, string name, string color) : base(price, weight, name, color)
        {
            this.powerConsumption = powerConsumption;
            this.brand = brand;
            this.warrantyYears = warrantyYears;
        }

        public override void DeviceDetails()
        {
            base.DeviceDetails();
            Console.WriteLine("------------------Sub-Category: Electronic Device----------------");
            Console.WriteLine($"Power Consumption: {powerConsumption}kWh");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Warranty period: {warrantyYears} Years");
        }
    }
}
