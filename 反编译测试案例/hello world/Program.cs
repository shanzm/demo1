using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "i am a student";
            string[] sArray = str.Split(new char[1] { ' ' });
            Array.Reverse(sArray);
            foreach (string item in sArray)
            {
                Console.WriteLine(item);
               
            }
            Print p = new hello_world.Print();
            p.DOPrint();

            int i = 12;
            Console.WriteLine("i=" + i);
          
            Console.ReadKey();
           

        }
    }
}
