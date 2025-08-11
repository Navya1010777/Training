using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        private string productName;
        private double productPrice;
        private double productQuantity;

        public Product()
        {
           
        }
        public Product(string productName, double productPrice, double productQuantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public double ProductQuantity
        {
            get{ return productQuantity; }
            set { productQuantity = value; }
        }
        public void ApplyDiscount(double discountPrice)
        {
            this.productPrice = this.productPrice - discountPrice;
        }

        public void getDetails()
        {
            Console.WriteLine("Enter product name");
            this.productName = Console.ReadLine();
            Console.WriteLine("Enter product price");
            this.productPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product quantity");
            this.productQuantity = Convert.ToInt32(Console.ReadLine());
        }
        public void printDetails()
        {
            Console.WriteLine("----------------------------Product Details---------------------------");
            Console.WriteLine($"Product Name:  {this.productName}");
            Console.WriteLine($"Product Price:  {this.productPrice}");
            Console.WriteLine($"Product Quantity: {this.productQuantity}");
        }




    }
}
