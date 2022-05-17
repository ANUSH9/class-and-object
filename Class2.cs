using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile
{
    class calculator
    {
        int num1;
        int num2;
        int num3;

        void add()
        {
           
            num3 = num1 + num2; 
            Console.WriteLine(num3);   
        }
        void subtract()
        {
            
            num3 = num2 - num1;
            Console.WriteLine(num3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello anush gupta");
            calculator obj1 = new calculator();
            obj1.num1 = 10;
            obj1.num2 = 50;
            
            obj1.add();
            obj1.subtract();    
            
        }
    }

}
