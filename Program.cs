using System;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine(); // citim primul număr
            decimal a = Convert.ToDecimal(inputData);
            bool b = true;
            if (a % 2 == 0)
            {
                b = false;
            }
            Console.WriteLine(b);
        }
    }
}
