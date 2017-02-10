using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.smallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialText = Console.ReadLine();

            string[] SmallestelementText = initialText.Split(' ');
            int[] SmallestelementNum = new int[SmallestelementText.Length];

            var min = 1000000000;
            for (int i = 0; i < SmallestelementNum.Length; i++)
            {
                SmallestelementNum[i] = int.Parse(SmallestelementText[i]);
            }
            for (int i = 0; i < SmallestelementNum.Length; i++)
            {
                if (SmallestelementNum[i]<min)
                {
                    min = SmallestelementNum[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
