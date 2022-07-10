using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] argv)
        {
            if (argv.Length != 1)
            {
                Console.WriteLine($"Usage: FibonacciSequence sequenceLength");
                return;
            }

            int length;

            if (!int.TryParse(argv[0], out length))
            {
                Console.WriteLine($"Usage: FibonacciSequence sequenceLength");
                return;
            }

            if (length < 2 || length > 93)
            {
                Console.WriteLine($"Usage: FibonacciSequence sequenceLength");
                return;
            }

            var result = Fibonacci.Calculate(length);
            for (var i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static class Fibonacci
    {
        
        public static long[] Calculate(int length)
        {
            if (length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            var sequence = new long[length];
            sequence[0] = 0;
            sequence[1] = 1;

            for (int i = 2; i < length; i++)
            {
                sequence[i] = sequence[i - 2] + sequence[i - 1];
            }

            return sequence;
        }
    }


}
