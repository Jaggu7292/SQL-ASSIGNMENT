using System;



namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y,z;
            Console.Write("enter the  first number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second number");
            y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Mul");
            Console.WriteLine("4.Div");
            Console.Write("select the operations which you requried:");
            z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine(x+y);
                    break;
                case 2: 
                    Console.WriteLine(x-y);
                    break;
                case 3:
                    Console.WriteLine(x * y);
                    break;
                case 4:
                    Console.WriteLine(x / y);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
             }

            Console.ReadLine();
        }
    }
}
