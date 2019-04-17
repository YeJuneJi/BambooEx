using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex
{
    class YejuneEx
    {
        static void Main(string[] args)
        {
            EvenFibonacci(); 
        }

        private static void EvenFibonacci()
        {
            int x = 1;
            int y = 2;
            int sum = 0;
            int inputNum = 0;
            try
            {
                Console.Write("Input >>");
                inputNum = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            
            

            while (x < inputNum)
            {
                if (x % 2 == 0)
                {
                    sum = sum + x;
                }
                int z = x + y;
                x = y;
                y = z;
                
            }
            Console.WriteLine("Output : {0}", sum);
            Console.WriteLine("Data Check Detected");
        }
    }
}
