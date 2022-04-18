using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapingTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 200;
            
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("swaped the x value "+x);
            Console.WriteLine("swaped the y value "+y);
            Console.ReadLine();
        }
    }
}
