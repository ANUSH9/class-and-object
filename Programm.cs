using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace work

{
    public class network
    {
        public void ReadLines()
        {
            FileStream fileStreamobj = new FileStream("F:\\132\\network.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Id\tSource\tDestination\tDate\tTime\tStatus\tNetwork");
            
            while (streamReaderobj.Peek() > 0)
            {
                string line = streamReaderobj.ReadLine();
                
                if (line != "")
                {
                    if (line.StartsWith("Id"))
                    {
                        string[] fine2 = line.Split(' ');

                        string[] fine1 = fine2[0].Split(':');

                        Console.Write(fine1[1] + "\t" + fine2[1] + "\t");
                        continue;
                    }
                    string[] fine = line.Split(':');
                    Console.Write(fine[1] + "\t");
                }
                else
                {
                    Console.WriteLine();
                }
                
                

            }
        }
    }
}