
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sale = new Sale(15m);
            Console.WriteLine(sale.GetInfo());
            Console.WriteLine($"Total con comisión: {sale.TotalWithCommission()}");
        }
    }
}
