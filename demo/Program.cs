using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //large carpet
            double large = 35;
            //small carpet
            double small = 25;
            //tax rate
            double tax = 0.06;
            //user entering
            Console.Write("Number of small carpets: ");
            double userSmall = double.Parse(Console.ReadLine());
            Console.Write("Number of large carpets: ");
            double userLarge = double.Parse(Console.ReadLine());
            double allSmall = small * userSmall;
            double allLarge = large * userLarge;
            Console.WriteLine($"Price per small room : ${small}");
            Console.WriteLine($"Price per small room : ${large}");
            double cost = allSmall + allLarge;
            Console.WriteLine($"Cost : ${cost}");
            double userTax = cost * tax;
            Console.WriteLine($"Tax :${userTax}");
            double totalEstimate = cost + userTax;
            Console.WriteLine($"Total estimate: ${totalEstimate}");
            Console.WriteLine("This estimate is valide for 30 days");
        }
    }
}
