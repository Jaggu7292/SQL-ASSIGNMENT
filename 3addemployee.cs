using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeedata
{
    internal class addemployee
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("jaggu");
            list.Add("Ranjith");
            list.Add("Kumar");
            list.Add("pandy");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }
            Console.WriteLine("total number of employess" + ':' + list.Count);
            Console.ReadLine();
        }
    }
}