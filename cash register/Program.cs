using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cash_register
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data
            double hundred = 100;
            double twenty = 20;
            double ten = 10;
            double five = 5;
            double one = 1;
            double q = 0.25;
            double d = .1;
            double n = .05;
            double p = .01;
            int h100 = 0;
            int t20 = 0;
            int t10 = 0;
            int f5 = 0;
            int o1 = 0;
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;
            int pennies = 0;

            Console.Write("Please enter total change due: $");
            string totalchangedue = Console.ReadLine();
            //double change = 10.69;
            double change = double.Parse(totalchangedue);
            Math.Round(change, 2);

            string total = change.ToString();
            // Calculation
            while (change >= hundred)
            {
                h100++;
                change = change - hundred;
                Math.Round(change, 2);
            }

            while (change >= twenty)
            {
                t20++;
                change = change - twenty;
                Math.Round(change, 2);
            }

            while (change >= ten)
            {
                t10++;
                change = change - ten;
                Math.Round(change, 2);
            }

            while (change >= five)
            {
                f5++;
                change = change - five;
                Math.Round(change, 2);
            }

            while (change >= one)
            {
                o1++;
                change = change - one;
                Math.Round(change, 2);
            }

            while (change >= q)
            {
                quarters++;
                change = change - q;
                Math.Round(change, 2);
            }

            while (change >= d)
            {
                dimes++;
                change = change - d;
                Math.Round(change, 2);
            }

            while (change >= n)
            {
                nickles++;
                change = change - n;
                Math.Round(change, 2);
            } 

            while (change < .05 && change >= 0.01 )
            {
                pennies++;
                change = change - p;
                Math.Round(change, 2);
            }

            // Display
            Console.WriteLine();
            Console.WriteLine("Your change due is: $" + total);
            Console.WriteLine();
            Console.WriteLine("hundreds: " + h100);
            Console.WriteLine("twenties: " + t20);
            Console.WriteLine("tens: " + t10);
            Console.WriteLine("fives: " + f5);
            Console.WriteLine("ones: " + o1);
            Console.WriteLine("quarters: " + quarters);
            Console.WriteLine("dimes: " + dimes);
            Console.WriteLine("nickles: " + nickles);
            Console.WriteLine("pennies: " + pennies);

            Console.ReadKey();
        }
    }
}

