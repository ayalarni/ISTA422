using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            RanNum start = new RanNum();

        }
    }
    class RanNum
    {
        int Min = 0;
        int Max = 1000;

        public RanNum()
        {
            Random index = new Random();
            int[] array = new int[index.Next(10 - 1000)];

            Random randNum = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(Min, Max);
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
}