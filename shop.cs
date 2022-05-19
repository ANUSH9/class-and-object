using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //File handling


namespace ConsoleDemo
{
    public class FileHandlingDemo
    {
        public void Information()
        {
            FileStream fd = new FileStream(@"F:\New folder\Informations.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sd = new StreamWriter(fd);
            Console.Write("enter phone number");
            sd.Write(Console.ReadLine());


            Console.WriteLine("Enter your first name");
            sd.Write(Console.ReadLine());

            Console.WriteLine("Enter your last name");
            sd.Write(Console.ReadLine());


            sd.Close();
            fd.Close();
            Console.WriteLine("File write operation completed");

        }
        public void productBuy()
        {
            FileStream fe = new FileStream(@"F:\New folder\product.txt", FileMode.Append, FileAccess.Write);
            StreamWriter se = new StreamWriter(fe);
            Console.Write("Enter the ProductID: ");
            se.Write(Console.ReadLine());
           

            Console.Write("Enter the ProductType: ");
            se.Write(Console.ReadLine());

            
            se.Close();
            fe.Close();
        }
        public void productBuydate()
        {
            FileStream fu = new FileStream(@"F:\New folder\productdate.txt", FileMode.Append, FileAccess.Write);
            StreamWriter su = new StreamWriter(fu);
            Console.Write("Enter the ProductID: ");
            su.Write(Console.ReadLine());
            

            Console.Write("Enter the ProductType: ");
            su.Write(Console.ReadLine());

            
            su.Close();
            fu.Close();
        }
        public void productPrice()
        {
            FileStream fo = new FileStream(@"F:\New folder\productprice.txt", FileMode.Append, FileAccess.Write);
            StreamWriter so = new StreamWriter(fo);
            Console.Write("Enter the Product Actual Price: ");
            so.Write(Console.ReadLine());

            Console.Write("Enter the Product Buy: ");
            so.Write(Console.ReadLine());

            Console.Write("Enter the Product Sell: ");
            so.Write(Console.ReadLine());

            




            so.Close();
            fo.Close();
        }
    }
}