using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.countOfOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialText = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;
            for (int i = 0; i < initialText.Length; i++)
            {
                if (initialText[i]%2 !=0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
