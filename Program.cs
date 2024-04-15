using System;
namespace new444
{
    class Program
    {
        public static void Main()
        {
            int rows, c = 1, s, i, j;
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pascal's triangle");
            for (i = 0; i < rows; i++)
            {
                for (s = 1; s <= rows - i; s++)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
