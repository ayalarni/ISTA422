using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter plain text");
            string plain_text = Console.ReadLine();
            Console.WriteLine($"You entered [{plain_text}]");

            Console.WriteLine("Enter your key as an upper case alpha character: ");
            string key = Console.ReadLine();
            Console.WriteLine($"You entered [{key}]");

            int[] clean_text = clean(plain_text);
            int[] clean_key = clean(key);
                    // int[] clean_text = new int[plain_text.Length];
            for (int i = 0, j = -1; i < plain_text.Length; i++)

            {
                int c = (int)plain_text[i];
                if (c > 90) c -= 32;
                if (c < 65 || c > 90) continue;
                clean_text[++j] = c;
              
                Console.WriteLine($"{c} == {plain_text[i]} == " +
                  $"  {(char)c} == {clean_text[j]}");
            }
            for (int i = 0; i < clean_text.Length; i++)
                Console.Write($"{clean_text[i]}");
            Console.WriteLine();

           //int[] encrypt_text = encrypt(clean_text, key)
        }

        private static int[] clean(string input)
        {
            int[]
            for (int i = 0, j = -1; i < input.Length; i++)

            {
                int c = (int)input[i];
                if (c > 90) c -= 32;
                if (c < 65 || c > 90) continue;
                clean_text[++j] = c;

                Console.WriteLine($"{c} == {plain_text[i]} == " +
                  $"  {(char)c} == {clean_text[j]}");
            }
            for (int i = 0; i < clean_text.Length; i++)
                Console.Write($"{clean_text[i]}");
            Console.WriteLine();
        }
    }
}