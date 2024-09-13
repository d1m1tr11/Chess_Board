using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int indeqsi = 0;
            for (int i=0; i<64;i++)
            {
                if (i % 8 == 0 && i>0)
                {
                    Console.WriteLine();
                    indeqsi++;
                }
                if (indeqsi % 2 ==0)
                {
                    Console.Write("|Tetri| ");
                }
                else { Console.Write("|Shavi| ");
                }

                indeqsi++;
            }
            
        }
    }
}
