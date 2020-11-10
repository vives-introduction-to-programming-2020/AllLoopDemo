using System;

namespace AllLoopDemo
{
    class Program
    {
        public static void CountDown(int from)
        {
            // 3 ... 2 ... 1 ... 0

            for (int i = from; i > 0; i--)
            {
                Console.Write($"{i} ... ");
                System.Threading.Thread.Sleep(1000);
            }

            Console.Write("0");
        }

        public static int Log2(int number)
        {
            // 2^3 = 8
            // 2^4 = 16
            // 2^0 = 1
            // How do we determine exponent (3 in this case)?
            //
            // Math.Log2()

            int exponent = 0;
            while (number > 1)
            {
                number = number / 2;
                exponent++;
            }

            return exponent;
        }

        public static void DieThrow(int numberOfDies, int minimum)
        {
            Random generator = new Random();

            int totalEyes = 0;

            do
            {
                for (int i = 0; i < numberOfDies; i++)
                {
                    int dieThrow = generator.Next(1, 7);
                    Console.WriteLine($"Die throw {i + 1}: {dieThrow}");

                    totalEyes += dieThrow;
                }
                Console.WriteLine($"Total number of eyes = {totalEyes}");

            } while (totalEyes < minimum);

        }

        public static int FindFirstCharacter(string text, char character)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == character)
                {
                    // This ends the for and the method
                    return i;
                }
            }
            return -1;
        }

        public static int FindFirstCharacterWhile(string text, char character)
        {       // text = Hello, character = 1
            int index = 0;
            while (index < text.Length && text[index] != character)
            {
                index++;
            }

            if (index < text.Length)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            // CountDown(5);

            Console.WriteLine($"Log2(16) = {Log2(16)}");
            Console.WriteLine($"Log2(1) = {Log2(1)}");
            Console.WriteLine($"Log2(17) = {Log2(17)}");

            // Aantal dobbelstenen te gooien
            // met Minimum totaal aantal ogen
            DieThrow(5, 16);

            // Find the index of the first occurence of the character
            string text = "The quick brown fox jumps over the brown lazy dog";

            Console.WriteLine($"Search for f: {FindFirstCharacter(text, 'f')}");
            Console.WriteLine($"Search for h: {FindFirstCharacter(text, 'h')}");
            Console.WriteLine($"Search for 1: {FindFirstCharacter(text, '1')}");

            Console.WriteLine($"Search for f: {FindFirstCharacterWhile(text, 'f')}");
            Console.WriteLine($"Search for h: {FindFirstCharacterWhile(text, 'h')}");
            Console.WriteLine($"Search for 1: {FindFirstCharacterWhile(text, '1')}");
        }
    }
}
