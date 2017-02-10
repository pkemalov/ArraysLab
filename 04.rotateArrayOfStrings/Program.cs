using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.rotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string initialText = Console.ReadLine();
            //string[] initialArrayOfStrings = initialText.Split(' ');

            var initialArrayOfStrings = Console.ReadLine().Split().ToArray();
            string[] rotatedArrayOfStrings = new string[initialArrayOfStrings.Length];

            for (int i = 0; i < rotatedArrayOfStrings.Length-1 ; i++)
            {
                
                rotatedArrayOfStrings[i+1] = initialArrayOfStrings[i];
            }
            var lastElement = initialArrayOfStrings[initialArrayOfStrings.Length - 1];
            rotatedArrayOfStrings[0] = lastElement;

            var result = string.Join(" ", rotatedArrayOfStrings);
            Console.WriteLine(result);
               
        }
    }
}
