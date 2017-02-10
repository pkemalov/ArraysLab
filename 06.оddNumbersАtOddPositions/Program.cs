using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.оddNumbersАtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOddNumbersAtOddPositions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arrayOddNumbersAtOddPositions.Length; i++)
            {
                if (i % 2 != 0 && arrayOddNumbersAtOddPositions[i] % 2 != 0)
                {
                    var result = $"Index {i} -> {arrayOddNumbersAtOddPositions[i]}";
                    Console.WriteLine(result);
                }
            }
            
        }
    }
}
