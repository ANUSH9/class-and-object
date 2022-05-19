using ConsoleDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Class2
    {
        static void Main(string[] args)
        {
            FileHandlingDemo fileHandlingDemoObj = new FileHandlingDemo();
            Console.WriteLine("Customer Detail");
            fileHandlingDemoObj.Information();

            Console.WriteLine("Product Buy");
            fileHandlingDemoObj.productBuy();

            Console.WriteLine("Product Buy date");
            fileHandlingDemoObj.productBuydate();

            Console.WriteLine("Product Price");
            fileHandlingDemoObj.productPrice();

            Console.ReadKey();

        }
    }
}
