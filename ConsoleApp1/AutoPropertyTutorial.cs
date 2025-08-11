using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AutoPropertyTutorial
    {
        //auto-implemented properties
        private int id;
        public int Id { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
        public string Age { get; set; }

        public AutoPropertyTutorial() { }

        public AutoPropertyTutorial(string name, string city, string age, int id)
        {
            Name = name;
            City = city;
            Age = age;
            this.Id = id;
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Age: {Age}");
        }

        public void UpdatePersonDetails()
        {
            Name = Name;
            City = City;
            Age = Age;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}