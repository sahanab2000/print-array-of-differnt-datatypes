using System;

using System.Collections.Generic;

namespace Generics
{ 
    
     class Program
    {
        

        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(".........");
        }



       
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };

            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };

            char[] charArray = { 'H', 'E', 'L', 'L', '0' };

            Program.toPrint<int>(intArray);

            Program.toPrint<double>(doubleArray);

            Program.toPrint<char>(charArray);
        }

    }

}