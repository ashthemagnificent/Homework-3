using System;

namespace Bölüm_8_ödev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The wage: ");
            double wage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The raise: ");
            double raise = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The number of year: ");
            double year = Convert.ToDouble(Console.ReadLine());

            for (double counter = 0; counter < year; counter++)

            {
                wage = (wage + wage * raise/100);
            }

            double NewWage = wage;

            
            Console.Clear();
            Console.WriteLine("The Latest Wage: {0}", wage);
            Console.ReadLine();



        



        }
    }
}
