using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.multiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());

            string[] arrayOfDoublesText = text.Split(' ');
            double[] arrayOfDoublesNum = new double[arrayOfDoublesText.Length];

            for (int i = 0; i < arrayOfDoublesNum.Length; i++)
            {
                arrayOfDoublesNum[i] = double.Parse(arrayOfDoublesText[i]);
            }

            double[] arrayOfDoublesMultiply = new double[arrayOfDoublesNum.Length];

            for (int i = 0; i < arrayOfDoublesMultiply.Length; i++)
            {
                arrayOfDoublesMultiply[i] = p * arrayOfDoublesNum[i];
            }

            var result = string.Join(" ", arrayOfDoublesMultiply);
            Console.WriteLine(result);

        }
    }
}
